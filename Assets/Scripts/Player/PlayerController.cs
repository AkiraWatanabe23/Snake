using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    private Rigidbody _rb = default;
    private Vector3 _moveDir = default;
    private float _hol = 0f;
    private float _ver = 0f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _hol = Input.GetAxisRaw("Horizontal");
        _ver = Input.GetAxisRaw("Vertical");

        _moveDir = Vector3.forward * _ver + Vector3.right * _hol;
        //_moveDir = Camera.main.transform.TransformDirection(_moveDir);
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
