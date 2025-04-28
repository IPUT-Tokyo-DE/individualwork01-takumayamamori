using UnityEngine;

public class RandomMotion : MonoBehaviour
{
    public Vector3 pointA = new Vector3(-5, 10, 0); // 始点
    public Vector3 pointB = new Vector3(-5, 0, 0);  // 終点
    public float speed = 10f;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = pointB;
    }

    // Update is called once per frame
    void Update()
    {
        // 現在位置からターゲットに向かって移動
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // ターゲットに到達したら次のターゲットに切り替え
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointA) ? pointB : pointA;
        }
    }
}
