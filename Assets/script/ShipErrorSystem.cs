using Cysharp.Threading.Tasks;
using UnityEngine;

public class ShipErrorSystem : MonoBehaviour
{
    public static ShipErrorSystem instance;
    public static bool audioErrorFlag=false;//曲が流れないことでSAN値が減る 0
    public static bool airConditioning=false;//空調エラーで長時間放置すると強制ゲームオーバー 1
    public static bool power = false;//パワーシステム、エラーを起こすことで消費電力が上がる 2
    public static bool weapons = false;//一部武器を使えない 3 
    public static bool shipSystem = false;//船全体のシステム、これが壊れるとエラー直すのが遅れるのと同時に表記されててるパラメーターがバグる 4

    public int RemainingPower;//残り電力、０になったらゲームオーバー
    public int SAN;
    public int Oxygen;
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

    public async UniTask FixError(EngineerBase engineer,int ErrorCode)
    {
        switch (ErrorCode)
        {
            case 0://AudioError
                
                break;
            case 1://airConditioningError

                break;
            case 2://PowerError

                break;
            case 3://WeaponsError

                break;
            case 4://ShipSystemError

                break;
        }
    }
}
