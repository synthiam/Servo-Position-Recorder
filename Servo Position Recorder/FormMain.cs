using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ARC.Config.Sub;
using Servo_Position_Recorder.Config;

namespace Servo_Position_Recorder {

  public partial class FormMain : ARC.UCForms.FormPluginMaster {

    readonly public static string _VariableIsRunning = "$IsServoRecorderRunning";

    public FormMain() {

      InitializeComponent();

      ConfigButton = false;
    }

    public override void SetConfiguration(PluginV1 cf) {

      ARC.Scripting.VariableManager.SetVariable(_VariableIsRunning, false);

      base.SetConfiguration(cf);

      updateRecordingControls();
    }

    public override PluginV1 GetConfiguration() {

      List<Recording> recordings = new List<Recording>();

      foreach (UCRecord ucr in flowLayoutPanel1.Controls)
        recordings.Add(ucr.GetConfig());

      MasterClass mc = new MasterClass();
      mc.Recordings = recordings.ToArray();

      _cf.SetCustomObjectV2(mc);

      return base.GetConfiguration();
    }

    void updateRecordingControls() {

      flowLayoutPanel1.SuspendLayout();

      flowLayoutPanel1.Controls.Clear();

      var masterClass = (MasterClass)_cf.GetCustomObjectV2(typeof(MasterClass));

      foreach (var recording in masterClass.Recordings) {

        var ucr = new UCRecord(recording);
        ucr.OnLog += Ucr_OnLog;
        ucr.OnDelete += Ucr_OnDelete;

        flowLayoutPanel1.Controls.Add(ucr);
      }

      flowLayoutPanel1.ResumeLayout();
    }

    private void Ucr_OnDelete(UCRecord o, Recording recording) {

      if (MessageBox.Show(string.Format("Delete {0}?", recording.Title), string.Empty, MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;

      flowLayoutPanel1.Controls.Remove(o);
    }

    private void Ucr_OnLog(object txt, params object[] param) {

      ARC.Invokers.SetAppendText(textBox1, true, 100, txt.ToString(), param);
    }

    private void btnAdd_Click(object sender, EventArgs e) {

      var ucr = new UCRecord(new Recording());

      ucr.OnLog += Ucr_OnLog;
      ucr.OnDelete += Ucr_OnDelete;

      flowLayoutPanel1.Controls.Add(ucr);
    }

    public override object[] GetSupportedControlCommands() {

      List<string> tmp = new List<string>();

      foreach (UCRecord ucr in flowLayoutPanel1.Controls) {

        tmp.Add(string.Format("\"Play\", \"{0}\"", ucr.GetConfig().Title));
        tmp.Add(string.Format("\"Stop\", \"{0}\"", ucr.GetConfig().Title));
      }

      return tmp.ToArray();
    }

    public override void SendCommand(string windowCommand, params string[] values) {

      if (values.Length != 1) {

        throw new Exception("Requires 1 parameter");
      }

      UCRecord ucr = null;

      foreach (UCRecord ucrTmp in flowLayoutPanel1.Controls)
        if (ucrTmp.GetConfig().Title.Equals(values[0], StringComparison.InvariantCultureIgnoreCase)) {

          ucr = ucrTmp;
          break;
        }

      if (ucr == null)
        throw new Exception(string.Format("Unable to find a recording named '{0}'", values[0]));

      if (windowCommand.Equals("Play", StringComparison.InvariantCultureIgnoreCase)) {

        ucr.Play();

      } else if (windowCommand.Equals("Stop", StringComparison.InvariantCultureIgnoreCase)) {

        ucr.Stop();

      } else {

        base.SendCommand(windowCommand, values);
      }
    }
  }
}
