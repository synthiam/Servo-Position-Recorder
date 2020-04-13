using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using ARC;
using Servo_Position_Recorder.Config;
using System.Drawing;

namespace Servo_Position_Recorder {

  public partial class UCRecord : UserControl {

    enum StateEnum {
      Stopped,
      Playing,
      Recording
    }

    StateEnum _state = StateEnum.Stopped;

    List<ServoPosition> _recordingPositions = new List<ServoPosition>();

    Recording _recording;

    Stopwatch _sw;

    EZ_B.EZTaskScheduler _ts;

    public event OnLogHandler OnLog;
    public delegate void OnLogHandler(object txt, params object[] param);

    public event OnDeleteHandler OnDelete;
    public delegate void OnDeleteHandler(UCRecord o, Recording recording);

    public UCRecord(Recording recording) {

      InitializeComponent();

      _recording = recording;

      updateTitle();

      _ts = new EZ_B.EZTaskScheduler(recording.Title, true);
      _ts.OnEventToRun += _ts_OnEventToRun;
      _ts.OnQueueCompleted += _ts_OnQueueCompleted;

      _sw = new Stopwatch();
    }

    private void _ts_OnQueueCompleted(EZ_B.EZTaskScheduler sender) {

      ARC.Scripting.VariableManager.SetVariable(FormMain._VariableIsRunning, false);
    }

    public Recording GetConfig() {

      return _recording;
    }

    void updateTitle() {

      lblTitle.Text = _recording.Title;

      TimeSpan ts = new TimeSpan();

      if (_recording.ServoPositions.Length > 0)
        ts = new TimeSpan(_recording.ServoPositions[_recording.ServoPositions.Length - 1].Ticks);

      label1.Text = string.Format("{0} Events\r\n{1}", _recording.ServoPositions.Length, ts);
    }

    private void _ts_OnEventToRun(EZ_B.EZTaskScheduler sender, int taskId, object o) {

      try {

        if (sender.IsCancelRequested(taskId))
          return;

        ARC.Scripting.VariableManager.SetVariable(FormMain._VariableIsRunning, true);

        _state = StateEnum.Playing;

        this.Invoke(new Action(() => {

          btnDelete.Enabled = false;
          btnRecord.Enabled = false;
          btnPlay.BackColor = Color.Red;
          btnPlay.ForeColor = Color.White;
          btnPlay.Text = "Stop";
        }));

        OnLog("{0}: Started", _recording.Title);

        _sw.Restart();

        foreach (var recording in _recording.ServoPositions) {

          if (sender.IsCancelRequested(taskId))
            return;

          while (_sw.ElapsedTicks < recording.Ticks) {

            if (sender.IsCancelRequested(taskId))
              return;

            System.Threading.Thread.Sleep(1);
          }

          EZBManager.EZBs[0].Servo.SetServoPosition(recording.GetAsEZBServoItems());
        }
      } catch (Exception ex) {

        OnLog("{0}: {1}", _recording.Title, ex.Message);
      } finally {

        ARC.Scripting.VariableManager.SetVariable(FormMain._VariableIsRunning, false);

        OnLog("{0}: Completed", _recording.Title);

        this.Invoke(new Action(() => {

          btnDelete.Enabled = true;
          btnRecord.Enabled = true;
          btnPlay.BackColor = Color.White;
          btnPlay.ForeColor = Color.Black;
          btnPlay.Text = "Play";
        }));

        _state = StateEnum.Stopped;
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {

      OnDelete(this, _recording);
    }

    public void Play() {

      if (_state != StateEnum.Stopped)
        return;

      if (_recording.ServoPositions.Length == 0)
        return;

      _ts.StartNew(new object());
    }

    public void Record() {

      if (_state != StateEnum.Stopped)
        return;

      btnDelete.Enabled = false;
      btnPlay.Enabled = false;
      btnRecord.BackColor = Color.Red;
      btnRecord.ForeColor = Color.White;
      btnRecord.Text = "Stop";

      _recordingPositions.Clear();

      string oldTitle = _recording.Title;

      _recording = new Recording();
      _recording.Title = oldTitle;

      updateTitle();

      _sw.Reset();

      _state = StateEnum.Recording;

      EZBManager.EZBs[0].Servo.OnServoMove += Servo_OnServoMove;
    }

    public void Stop() {

      _sw.Stop();

      if (_state == StateEnum.Playing) {

        _ts.CancelCurrentTask();
      } else if (_state == StateEnum.Recording) {

        _state = StateEnum.Stopped;

        EZBManager.EZBs[0].Servo.OnServoMove -= Servo_OnServoMove;

        _recording.ServoPositions = _recordingPositions.ToArray();

        updateTitle();

        this.Invoke(new Action(() => {

          btnDelete.Enabled = true;
          btnPlay.Enabled = true;
          btnRecord.BackColor = Color.White;
          btnRecord.ForeColor = Color.Black;
          btnRecord.Text = "Record";
        }));
      }
    }

    private void btnRecord_Click(object sender, EventArgs e) {

      if (_state == StateEnum.Recording)
        Stop();
      else if (_state == StateEnum.Stopped)
        Record();
    }

    private void Servo_OnServoMove(EZ_B.Classes.ServoPositionItem[] servos) {

      if (_state != StateEnum.Recording)
        return;

      var tmp = new ServoPositionItem[servos.Length];

      for (int i = 0; i < servos.Length; i++)
        tmp[i] = new ServoPositionItem() {
          Port = servos[i].Port,
          Position = servos[i].Position
        };

      _recordingPositions.Add(new ServoPosition() {
        Ticks = _sw.ElapsedTicks,
        Servos = tmp
      });

      if (!_sw.IsRunning)
        _sw.Restart();
    }

    private void btnPlay_Click(object sender, EventArgs e) {

      if (_state == StateEnum.Stopped)
        Play();
      else if (_state == StateEnum.Playing)
        Stop();
    }

    private void lblTitle_Click(object sender, EventArgs e) {

      using (var form = new ARC.FormPromptText("Rename this recording:", _recording.Title)) {

        if (form.ShowDialog() != DialogResult.OK)
          return;

        _recording.Title = form.GetText;

        updateTitle();
      }
    }
  }
}