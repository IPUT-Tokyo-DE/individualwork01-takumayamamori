using UnityEngine;

public class RandomMotion4 : MonoBehaviour
{
    public Vector3 pointG = new Vector3(-20, 0, 0); // �n�_
    public Vector3 pointH = new Vector3(-20, -10, 0);  // �I�_
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
        // ���݈ʒu����^�[�Q�b�g�Ɍ������Ĉړ�
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // �^�[�Q�b�g�ɓ��B�����玟�̃^�[�Q�b�g�ɐ؂�ւ�
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = (target == pointG) ? pointH : pointG;
        }
    }
}

