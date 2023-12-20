using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "PlayerController", menuName = "Input/PlayerController")]
public class PlayerController : InputController
{
    PlayerInputActions _inputActions;
    bool _isJumping;

    void OnEnable()
    {
        _inputActions = new PlayerInputActions();
        _inputActions.Player.Enable();
        _inputActions.Player.Jump.started += JumpStarted;
        _inputActions.Player.Jump.canceled += JumpCanceled;
    }

    void OnDisable()
    {
        _inputActions.Player.Disable();
        _inputActions.Player.Jump.started -= JumpStarted;
        _inputActions.Player.Jump.canceled -= JumpCanceled;
    }

    void JumpStarted(InputAction.CallbackContext context)
    {
        _isJumping = true;
    }
    void JumpCanceled(InputAction.CallbackContext context)
    {
        _isJumping = false;
    }
    public override bool RetrieveJumpInput(GameObject gameObject)
    {
        return _isJumping;
    }

    public override float RetrieveMoveInput(GameObject gameObject)
    {
        return _inputActions.Player.Move.ReadValue<Vector2>().x;
    }
}
