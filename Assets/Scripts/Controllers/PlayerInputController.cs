using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;



    private void Awake()
    {
        _camera = Camera.main;
    }

    private void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    private void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPosition = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPosition - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= 0.9f)
        {
            CallLookEvent(newAim);
        }
    }
}
