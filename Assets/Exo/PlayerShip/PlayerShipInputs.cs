using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipInputs : MonoBehaviour
{
    private PlayerInput _playerInput;

    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField] 
    private GameObject _bombPrefab;

    [SerializeField]
    private GameObject _uiText;

    [SerializeField]
    private float _moveSpeed;

    private Vector2 _moveInput;

    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _uiText.SetActive(false);
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

    public void Bomb(InputAction.CallbackContext context)
    {  
        if (context.performed)
        {
            Instantiate(_bombPrefab, transform.position, transform.rotation);
        }
    }

    public void PauseInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Pause");
            GoPause();
        }
    }

    private void GoPause()
    {         
        _playerInput.SwitchCurrentActionMap("UI");
        Debug.Log("Switched to UI map");
        _uiText.SetActive(true);
        Time.timeScale = 0f;
    }

    public void QuitPauseInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Pause");
            ResumeGame();
        }
    }

    private void ResumeGame()
    {
        _playerInput.SwitchCurrentActionMap("Game");
        Debug.Log("Switched to Game map");
        _uiText.SetActive(false);
        Time.timeScale = 1f;

    }
}
