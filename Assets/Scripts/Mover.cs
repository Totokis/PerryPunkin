using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _movementForce = 5f;
    [SerializeField] private float _maxHorizontalVelocity = 5f;
    [SerializeField] private float _maxVerticalVelocity = 5f;
    
    
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        _rigidbody.AddForce(horizontal * _movementForce,0,0);

        float clampedX = Mathf.Clamp(_rigidbody.velocity.x, -_maxHorizontalVelocity, _maxHorizontalVelocity);
        
        float clampedY = Mathf.Clamp(_rigidbody.velocity.y, -_maxVerticalVelocity, _maxVerticalVelocity);
        
        _rigidbody.velocity = new Vector3(clampedX, clampedY, _rigidbody.velocity.z);
    }
    
}
