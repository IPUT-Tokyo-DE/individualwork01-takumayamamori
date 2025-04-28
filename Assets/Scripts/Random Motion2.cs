using UnityEngine;

public class RandomMotion2 : MonoBehaviour
{
    public Vector3 pointC = new Vector3(-10, 0, 0); // 始点
    public Vector3 pointD = new Vector3(-10, -10, 0);  // 終点
    public float speed = 10f;
    private Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = pointD;
    }

    // Update is called once per frame
    void Update()
    {
        // 現在位置からターゲットに向かって移動
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // ターゲットに到達したら次のターゲットに切り替え
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointC) ? pointD : pointC;
        }
    }
}

