// GENERATED AUTOMATICALLY FROM 'Assets/_Settings/MyInputAction.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Reynold.Medieval
{
    public class MyInputAction : IInputActionCollection
    {
        private InputActionAsset asset;
        public MyInputAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyInputAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b0b5aa98-a4d7-47ad-a317-10a529ed0cec"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ddedd63e-bdb4-4359-8019-9b8714c925c9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""35b064d0-a3ef-452b-a72d-c9ae3fad6e13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""085c65be-3d8e-454a-8487-a50c5ac2ca45"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector Movement"",
                    ""id"": ""bf0bbdb8-f18f-41cd-8ef0-5a4b0c094b16"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a8886341-9162-49e9-a70a-98ba2d116df4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6e8ea80e-3f48-4d83-8389-b49b59de2097"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c37f6af3-cccc-4886-af6c-d1cbd3bb2825"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f94a2fb4-78c1-4e7d-a0ae-3b383691d244"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4f606a90-23de-4f97-8fd8-95952bff7e45"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4146f22-0cbf-43ef-b8e8-b23838086ff7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.GetActionMap("Player");
            m_Player_Movement = m_Player.GetAction("Movement");
            m_Player_Sprint = m_Player.GetAction("Sprint");
            m_Player_Interact = m_Player.GetAction("Interact");
        }

        ~MyInputAction()
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

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Movement;
        private readonly InputAction m_Player_Sprint;
        private readonly InputAction m_Player_Interact;
        public struct PlayerActions
        {
            private MyInputAction m_Wrapper;
            public PlayerActions(MyInputAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Player_Movement;
            public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
            public InputAction @Interact => m_Wrapper.m_Player_Interact;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                    Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                    Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Movement.started += instance.OnMovement;
                    Movement.performed += instance.OnMovement;
                    Movement.canceled += instance.OnMovement;
                    Sprint.started += instance.OnSprint;
                    Sprint.performed += instance.OnSprint;
                    Sprint.canceled += instance.OnSprint;
                    Interact.started += instance.OnInteract;
                    Interact.performed += instance.OnInteract;
                    Interact.canceled += instance.OnInteract;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnInteract(InputAction.CallbackContext context);
        }
    }
}
