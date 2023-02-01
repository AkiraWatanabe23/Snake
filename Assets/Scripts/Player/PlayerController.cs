using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private Rigidbody _rb = default;
    private Vector3 _moveDir = default;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float hol = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        _moveDir = Vector3.forward * ver + Vector3.right * hol;
        _moveDir = Camera.main.transform.TransformDirection(_moveDir);
        _moveDir.y = 0f;

        Vector3 forward = _rb.velocity;
        forward.y = 0;

        if (forward != Vector3.zero)
        {
            transform.forward = forward;
        }
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_moveDir.normalized * _moveSpeed - _rb.velocity);
    }
}
