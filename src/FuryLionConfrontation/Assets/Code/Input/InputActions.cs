//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Code/Input/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""4e4575b8-9b2f-407c-9319-c3883910d735"",
            ""actions"": [
                {
                    ""name"": ""CursorPosition"",
                    ""type"": ""Value"",
                    ""id"": ""ac5c32c7-7ec6-48e9-94b6-837194c95509"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""85a1faa7-465a-4cd7-b226-8ee802e17d23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""2f61e972-1021-461f-ad85-14f5a808860d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""6dccd0f6-1cba-4b2b-a611-e6c855b3f80a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5194888c-b72d-470c-ae4d-2c8c9f05783b"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""CursorPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45fabf3d-51a9-432e-a3c4-e11f630fa4e7"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50504ea2-25b6-4a79-ba82-6e48593f6bca"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e154ef76-c204-4420-975a-1c399becb362"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_CursorPosition = m_Gameplay.FindAction("CursorPosition", throwIfNotFound: true);
        m_Gameplay_Tap = m_Gameplay.FindAction("Tap", throwIfNotFound: true);
        m_Gameplay_Press = m_Gameplay.FindAction("Press", throwIfNotFound: true);
        m_Gameplay_Release = m_Gameplay.FindAction("Release", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_CursorPosition;
    private readonly InputAction m_Gameplay_Tap;
    private readonly InputAction m_Gameplay_Press;
    private readonly InputAction m_Gameplay_Release;
    public struct GameplayActions
    {
        private @InputActions m_Wrapper;
        public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CursorPosition => m_Wrapper.m_Gameplay_CursorPosition;
        public InputAction @Tap => m_Wrapper.m_Gameplay_Tap;
        public InputAction @Press => m_Wrapper.m_Gameplay_Press;
        public InputAction @Release => m_Wrapper.m_Gameplay_Release;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @CursorPosition.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCursorPosition;
                @CursorPosition.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCursorPosition;
                @Tap.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTap;
                @Press.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPress;
                @Release.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRelease;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CursorPosition.started += instance.OnCursorPosition;
                @CursorPosition.performed += instance.OnCursorPosition;
                @CursorPosition.canceled += instance.OnCursorPosition;
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnCursorPosition(InputAction.CallbackContext context);
        void OnTap(InputAction.CallbackContext context);
        void OnPress(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
    }
}
