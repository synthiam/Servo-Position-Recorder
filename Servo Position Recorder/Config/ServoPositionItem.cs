using System;

namespace Servo_Position_Recorder.Config {

  [Serializable]
  public class ServoPositionItem {

    public EZ_B.Servo.ServoPortEnum Port;
    public int Position;
  }
}
