using UnityEngine;

public class MoveShip : MonoBehaviour
{
    private Vector3 target;
    private Vector3 mouse;
    public GameObject GameObject;
    public float destroyTime;
    [SerializeField] GameObject PlayerBulletPrefab;
    GameObject ball;
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
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    void Shot()
    {
        ball = Instantiate(PlayerBulletPrefab) as GameObject;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 worldDir = ray.direction;
        Quaternion quaternion = Quaternion.LookRotation(worldDir);
        ball.transform.rotation =quaternion;
        ball.GetComponent<Bullet>().Shoot(worldDir.normalized*3000);
        Destroy(ball,destroyTime);
    }
}
