using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += horizontalInput * moveSpeed * Time.deltaTime;
        pos.y += verticalInput * moveSpeed * Time.deltaTime;

        transform.position = pos;
    }
}
