using UnityEngine;

public class RandomMotion4 : MonoBehaviour
{
    public Vector3 pointG = new Vector3(-20, 0, 0); // 始点
    public Vector3 pointH = new Vector3(-20, -10, 0);  // 終点
    public float speed = 10f;
    private Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = pointH;
    }

    // Update is called once per frame
    void Update()
    {
        // 現在位置からターゲットに向かって移動
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // ターゲットに到達したら次のターゲットに切り替え
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointG) ? pointH : pointG;
        }
    }
}

