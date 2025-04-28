using UnityEngine;

public class RandomMotion3 : MonoBehaviour
{
    public Vector3 pointE = new Vector3(-15, 10, 0); // �n�_
    public Vector3 pointF = new Vector3(-15, 0, 0);  // �I�_
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
        // ���݈ʒu����^�[�Q�b�g�Ɍ������Ĉړ�
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // �^�[�Q�b�g�ɓ��B�����玟�̃^�[�Q�b�g�ɐ؂�ւ�
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointE) ? pointF : pointE;
        }
    }
}

