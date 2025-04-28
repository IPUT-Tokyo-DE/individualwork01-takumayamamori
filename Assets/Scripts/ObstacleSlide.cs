using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class ObstacleSlide : MonoBehaviour
{
    [Header("Physics Materials")]
    [SerializeField] private PhysicsMaterial2D normalMaterial;
    [SerializeField] private PhysicsMaterial2D slipperyMaterial;

    private Rigidbody2D rb;
    private Collider2D col;

    [Header("Slippery Settings")]
    [SerializeField] private float slipperyDamping = 0.2f;
    [SerializeField] private float slideSpeed = 20f;

    [Header("Slide Boost")]
    [SerializeField] private float initialSlideBoost = 100f;

    private bool isSliding = false;
    private Vector2 slideDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    private void Start()
    {
        SetMaterial(normalMaterial);
        rb.linearDamping = 1f;
    }

    private void Update()
    {
        if (isSliding)
        {
            // 速度が一定以上に落ちたら滑り終了（お好み）
            if (rb.linearVelocity.magnitude < 0.1f)
            {
                StopSliding();
            }
        }
    }

    private void StopSliding()
    {
        isSliding = false;
        SetMaterial(normalMaterial);
        rb.linearDamping = 1f;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") || collision.collider.CompareTag("Obstacle"))
        {
            if (collision.contacts.Length > 0)
            {
                slideDirection = (transform.position - collision.transform.position).normalized;
                StartSliding();
            }
        }
    }

    private void StartSliding()
    {
        SetMaterial(slipperyMaterial);
        rb.linearDamping = slipperyDamping;
        isSliding = true;

        // 滑り出しの速度セット
        rb.linearVelocity = slideDirection * slideSpeed;

        // 💥 インパルスで追加の滑り力を与える
        rb.AddForce(slideDirection * slideSpeed * initialSlideBoost, ForceMode2D.Impulse);
    }

    private void SetMaterial(PhysicsMaterial2D material)
    {
        if (col != null)
        {
            col.sharedMaterial = material;
        }
    }
}
