using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller; // Reference to the CharacterController component
    private Vector3 playerVelocity; // Stores the player's velocity for movement calculations
    public float speed = 5f; // Movement speed of the player
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

    }

    // recieves the input from the InputManager.cs and apply to Character Controller
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    }
}
