using UnityEngine;
using UnityEngine.InputSystem;

public class SnakeController : MonoBehaviour
{
    public float moveSpeed = 6.5f;
    public float turnSpeed = 360f;

    private float turnInput;

    void Update()
    {
        ReadInput();
        HandleRotation();
        HandleMovement();
    }

    private void ReadInput()
    {
        turnInput = 0f;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            turnInput = -1f;
        }
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            turnInput = 1f;
        }
    }

    private void HandleRotation()
    {
        float rotationAmount = turnInput * turnSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);
    }

    private void HandleMovement()
    {
        transform.position += moveSpeed * Time.deltaTime * transform.forward;
    }
}
