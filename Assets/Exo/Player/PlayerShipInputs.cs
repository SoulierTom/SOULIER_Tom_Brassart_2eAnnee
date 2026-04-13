using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipInputs : MonoBehaviour
{
    private ExoInputAction _newInputSystemActions;

    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private float _moveSpeed;

    private Vector2 _moveInput;

    private void Start()
    {
        _newInputSystemActions = new ExoInputAction();
    }

    private void Update()
    {
        transform.Translate(_moveInput * Time.deltaTime * _moveSpeed);
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Shoot");
            Instantiate(_bulletPrefab, transform.position, transform.rotation);
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _moveInput = context.ReadValue<Vector2>();
        }

        if (context.canceled)
        {
           _moveInput = Vector2.zero;
        }
    }
}
