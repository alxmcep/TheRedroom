using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller; // Reference to the CharacterController component
    private Vector3 playerVelocity; // Stores the player's velocity for movement calculations
    private bool isGrounded; // Flag to check if the player is grounded
    public float gravity = -9.81f; // Gravity value to apply to the player
    public float speed = 5f; // Movement speed of the player
    public float jumpHeight = 3f; // Height of the player's jump
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = controller.isGrounded; // Check if the player is grounded
    }

    // recieves the input from the InputManager.cs and apply to Character Controller
    public void ProcessMove(Vector2 input)
    {
        // Calculate the movement direction based on input
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);

        // Apply gravity to the player's vertical velocity
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f; // Reset vertical velocity when grounded
        }
        controller.Move(playerVelocity * Time.deltaTime);
        Debug.Log(playerVelocity.y);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity); // Calculate jump velocity based on jump height and gravity
        }
    }
}
