using UnityEngine;

public class RandomMotion : MonoBehaviour
{
    public Vector3 pointA = new Vector3(-5, 10, 0); // �n�_
    public Vector3 pointB = new Vector3(-5, 0, 0);  // �I�_
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
        // ���݈ʒu����^�[�Q�b�g�Ɍ������Ĉړ�
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // �^�[�Q�b�g�ɓ��B�����玟�̃^�[�Q�b�g�ɐ؂�ւ�
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointA) ? pointB : pointA;
        }
    }
}
