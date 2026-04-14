using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private NewActions _newInputSystemActions;


    private void Start()
    {
        _newInputSystemActions = new NewActions();
        _newInputSystemActions.Player.Shoot.performed += Shoot;
    }

    private void Update()
    {
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            Debug.Log("Go Forward");
        }
    }

    public void Shoot(InputAction.CallbackContext context)
    {
   
        Debug.Log("Shoot");
       
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log($"Move input value : {context.ReadValue<Vector2>()}");
            
        }
    }


}
