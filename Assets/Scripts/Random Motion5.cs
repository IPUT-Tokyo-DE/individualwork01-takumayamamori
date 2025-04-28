using UnityEngine;

public class RandomMotion5 : MonoBehaviour
{
    public Vector3 pointI = new Vector3(-30, 15, 0); // �n�_
    public Vector3 pointJ = new Vector3(-30, -15, 0);  // �I�_
    public float speed = 15f;
    private Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = pointJ;
    }

    // Update is called once per frame
    void Update()
    {
        // ���݈ʒu����^�[�Q�b�g�Ɍ������Ĉړ�
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // �^�[�Q�b�g�ɓ��B�����玟�̃^�[�Q�b�g�ɐ؂�ւ�
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointI) ? pointJ : pointI;
        }
    }
}

