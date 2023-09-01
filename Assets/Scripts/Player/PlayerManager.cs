using UnityEngine;
using UnityEngine.InputSystem;

/*
 * Handles inputs and actions related to direct player control within the game
 * (switching game modes, drag/drop, etc)
 */
public class PlayerManager: MonoBehaviour
{
    private PlayerInputActions _playerInputActions;
    private InputAction _interactAction;
    private InputAction _craftingModeAction;
    private InputAction _pauseMenuAction;

    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        _interactAction = _playerInputActions.GameControls.Interact;
        _interactAction.Enable();
        _interactAction.performed += InteractWIthObject;

        _craftingModeAction = _playerInputActions.GameControls.CraftingMode;
        _craftingModeAction.Enable();
        _craftingModeAction.performed += toggleCraftingMode => GameManager.instance.ToggleGameMode(GameManager.GameMode.Crafting);

        _pauseMenuAction = _playerInputActions.GameControls.PauseMenu;
        _pauseMenuAction.Enable();
        _pauseMenuAction.performed += togglePauseMenu => GameManager.instance.ToggleGameMode(GameManager.GameMode.PauseMenu);
    }

    private void InteractWIthObject(InputAction.CallbackContext context)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        // TODO: implement a better way to interact with things. For now, a dedicated layer will work.
        if (Physics.Raycast(ray, out hit, 100, LayerMask.GetMask("Interactable"))) 
        {
            // only the crafting table is interactable... quick and dirty for now
            // TODO: add hover effect, implement events for interactable objects?
            //hit.collider.GetComponent<>();
            GameManager.instance.SetGameMode(GameManager.GameMode.Crafting);
        }
    }

    private void OnDisable()
    {
        _craftingModeAction.Disable();
        _pauseMenuAction.Disable();
    }
}
