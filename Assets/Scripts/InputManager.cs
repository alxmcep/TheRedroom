// This script is responsible for managing player input using the new Input System in Unity.
// It initializes the PlayerInput component and sets up the OnFoot action map for handling player movement and actions.

using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput; // Reference to the PlayerInput component
    private PlayerInput.OnFootActions onFoot; // Reference to the OnFoot action map
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // This method is called when the script is enabled. It enables the OnFoot action map to start receiving input.
    private void OnEnable()
    {
        onFoot.Enable();
    }

    // This method is called when the script is disabled. It disables the OnFoot action map to stop receiving input.
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
