using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ResetOnGoal : MonoBehaviour
{
    [Header("プレイヤーオブジェクト")]
    [SerializeField] private GameObject playerObject;

    private Vector3 _initialPosition;
    private Vector3 _playerInitialPosition;

    private Rigidbody2D _rigidbody;
    private Rigidbody2D _playerRigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        if (playerObject != null)
        {
            _playerRigidbody = playerObject.GetComponent<Rigidbody2D>();
        }
    }

    void Start()
    {
        _initialPosition = transform.position;

        if (playerObject != null)
        {
            _playerInitialPosition = playerObject.transform.position;
        }
    }

    void Update()
    {
        // Enterキー（Returnキー）が押されたらリセット
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ResetToStart();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Goal"))
        {
            ResetToStart();
        }
    }

    private void ResetToStart()
    {
        // 自分の位置をリセット
        transform.position = _initialPosition;
        _rigidbody.linearVelocity = Vector2.zero;
        _rigidbody.angularVelocity = 0f;

        // プレイヤーの位置をリセット
        if (playerObject != null)
        {
            playerObject.transform.position = _playerInitialPosition;

            if (_playerRigidbody != null)
            {
                _playerRigidbody.linearVelocity = Vector2.zero;
                _playerRigidbody.angularVelocity = 0f;
            }
        }
    }
}
