using System;

namespace Servo_Position_Recorder.Config {

  [Serializable]
  public class Recording {

    public string Title = "No Name";
    public ServoPosition [] ServoPositions = new ServoPosition[]{ };
    public Guid GUID = Guid.NewGuid();
  }
}
