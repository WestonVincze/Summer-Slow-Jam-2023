//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Inputs/Player/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""GameControls"",
            ""id"": ""40643f5c-2362-4ae7-b5ff-994684b9d539"",
            ""actions"": [
                {
                    ""name"": ""CraftingMode"",
                    ""type"": ""Button"",
                    ""id"": ""9c2a8624-080c-4a68-a517-e190d994e9a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""99ce2f5e-2c4f-4e27-8616-7e9593fb230b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraLock"",
                    ""type"": ""Button"",
                    ""id"": ""fe8961fb-ad88-46a6-b045-cf2a20b32c9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DebugMode"",
                    ""type"": ""Button"",
                    ""id"": ""88746750-dadf-40fb-b960-7a5efd520b4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75fc1ffd-5bb4-4c44-86b4-86cd91156ede"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CraftingMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48a74933-af63-4f99-80ce-246c569e8444"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b2e5d82-1a4f-4c78-a9bf-e4f7e737e738"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97d630dd-da01-4115-90e8-c7bb1da29411"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameControls
        m_GameControls = asset.FindActionMap("GameControls", throwIfNotFound: true);
        m_GameControls_CraftingMode = m_GameControls.FindAction("CraftingMode", throwIfNotFound: true);
        m_GameControls_PauseMenu = m_GameControls.FindAction("PauseMenu", throwIfNotFound: true);
        m_GameControls_CameraLock = m_GameControls.FindAction("CameraLock", throwIfNotFound: true);
        m_GameControls_DebugMode = m_GameControls.FindAction("DebugMode", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // GameControls
    private readonly InputActionMap m_GameControls;
    private List<IGameControlsActions> m_GameControlsActionsCallbackInterfaces = new List<IGameControlsActions>();
    private readonly InputAction m_GameControls_CraftingMode;
    private readonly InputAction m_GameControls_PauseMenu;
    private readonly InputAction m_GameControls_CameraLock;
    private readonly InputAction m_GameControls_DebugMode;
    public struct GameControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public GameControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CraftingMode => m_Wrapper.m_GameControls_CraftingMode;
        public InputAction @PauseMenu => m_Wrapper.m_GameControls_PauseMenu;
        public InputAction @CameraLock => m_Wrapper.m_GameControls_CameraLock;
        public InputAction @DebugMode => m_Wrapper.m_GameControls_DebugMode;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void AddCallbacks(IGameControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_GameControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameControlsActionsCallbackInterfaces.Add(instance);
            @CraftingMode.started += instance.OnCraftingMode;
            @CraftingMode.performed += instance.OnCraftingMode;
            @CraftingMode.canceled += instance.OnCraftingMode;
            @PauseMenu.started += instance.OnPauseMenu;
            @PauseMenu.performed += instance.OnPauseMenu;
            @PauseMenu.canceled += instance.OnPauseMenu;
            @CameraLock.started += instance.OnCameraLock;
            @CameraLock.performed += instance.OnCameraLock;
            @CameraLock.canceled += instance.OnCameraLock;
            @DebugMode.started += instance.OnDebugMode;
            @DebugMode.performed += instance.OnDebugMode;
            @DebugMode.canceled += instance.OnDebugMode;
        }

        private void UnregisterCallbacks(IGameControlsActions instance)
        {
            @CraftingMode.started -= instance.OnCraftingMode;
            @CraftingMode.performed -= instance.OnCraftingMode;
            @CraftingMode.canceled -= instance.OnCraftingMode;
            @PauseMenu.started -= instance.OnPauseMenu;
            @PauseMenu.performed -= instance.OnPauseMenu;
            @PauseMenu.canceled -= instance.OnPauseMenu;
            @CameraLock.started -= instance.OnCameraLock;
            @CameraLock.performed -= instance.OnCameraLock;
            @CameraLock.canceled -= instance.OnCameraLock;
            @DebugMode.started -= instance.OnDebugMode;
            @DebugMode.performed -= instance.OnDebugMode;
            @DebugMode.canceled -= instance.OnDebugMode;
        }

        public void RemoveCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_GameControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);
    public interface IGameControlsActions
    {
        void OnCraftingMode(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnCameraLock(InputAction.CallbackContext context);
        void OnDebugMode(InputAction.CallbackContext context);
    }
}
