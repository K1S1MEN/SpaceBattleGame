using UnityEngine;

public class MoveShip : MonoBehaviour
{
    private Vector3 target;
    private Vector3 mouse;
    public GameObject GameObject;

    [SerializeField] GameObject PlayerBullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 10));
        GameObject.transform.position = target;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BattleManeger.PlayerPose = !BattleManeger.PlayerPose;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
