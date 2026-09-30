using UnityEngine;

public class BattleManeger : MonoBehaviour
{
    public static bool PlayerPose  = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPose)
        {

        }
    }

    void Finish()
    {

    }
}
