using System;

namespace Servo_Position_Recorder.Config {

  [Serializable]
  public class ServoPosition {

    public long Ticks;
    public ServoPositionItem [] Servos = new ServoPositionItem[]{ };

    public EZ_B.Classes.ServoPositionItem[] GetAsEZBServoItems() {

      var si = new EZ_B.Classes.ServoPositionItem[Servos.Length];

      for (int x = 0; x < Servos.Length; x++)
        si[x] = new EZ_B.Classes.ServoPositionItem(
          Servos[x].Port,
          Servos[x].Position);

      return si;
    }
  }
}
