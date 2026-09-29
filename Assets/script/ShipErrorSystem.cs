using UnityEngine;

public class ShipErrorSystem : MonoBehaviour
{
    public static ShipErrorSystem instance;
    public static bool audioErrorFlag=false;//曲が流れないことでSAN値が減る
    public static bool airConditioning=false;//空調エラーで長時間放置すると強制ゲームオーバー
    public static bool power = false;//パワーシステム、エラーを起こすことで消費電力が上がる
    public static bool weapons = false;//一部武器を使えない
    public static bool shipSystem = false;//船全体のシステム、これが壊れるとエラー直すのが遅れるのと同時に表記されててるパラメーターがバグる

    public int RemainingPower;//残り電力、０になったらゲームオーバー
    private void Awake()
    {
       instance = this;
    }

    public void Reboot()
    {

    }
    public void AllReboot()
    {

    }

    public void SendEngineer()
    {

    }
}
