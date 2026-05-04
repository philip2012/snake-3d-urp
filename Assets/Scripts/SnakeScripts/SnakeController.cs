using UnityEngine;
using UnityEngine.InputSystem;

public class SnakeController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 6.5f;
    [SerializeField] public float turnSpeed = 360f;

    // progressive dificulty tunables
    [SerializeField] public float maxMoveSpeed = 14f;
    [SerializeField] public float speedIncreasePerFood = 0.25f;

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

    public void IncreaseSpeed()
    {
        moveSpeed += speedIncreasePerFood;
        moveSpeed = Mathf.Clamp(moveSpeed, 0f, maxMoveSpeed);

        Debug.Log($"Speed: {moveSpeed}");
    }
}
