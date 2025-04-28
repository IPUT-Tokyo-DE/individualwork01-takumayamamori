using UnityEngine;

public class RandomMotion3 : MonoBehaviour
{
    public Vector3 pointE = new Vector3(-15, 10, 0); // 始点
    public Vector3 pointF = new Vector3(-15, 0, 0);  // 終点
    public float speed = 10f;
    private Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = pointF;
    }

    // Update is called once per frame
    void Update()
    {
        // 現在位置からターゲットに向かって移動
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // ターゲットに到達したら次のターゲットに切り替え
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointE) ? pointF : pointE;
        }
    }
}

