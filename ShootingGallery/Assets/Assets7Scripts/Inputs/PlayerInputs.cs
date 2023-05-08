//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Inputs/PlayerInputs.inputactions
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

namespace Inputs
{
    public partial class @PlayerInputs : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""World"",
            ""id"": ""a8bebb75-8115-4614-b4da-fd4b09f197c0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""bd3f1893-5811-44ab-b6b4-c30cd759dceb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6b083803-2410-4117-aa85-52d31b927e57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""eaccc77c-046a-4f7e-93e3-d318e95f1425"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""03237d84-6479-488b-918e-e2bd075154df"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""51f23f12-f2e2-425f-9317-1f07d104676a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""4d900530-a5ed-41a9-adee-a15303f64cd4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeWeapon1"",
                    ""type"": ""Button"",
                    ""id"": ""17254c3c-b5d0-42c6-96ca-61b895e4253c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ChangeWeapon2"",
                    ""type"": ""Button"",
                    ""id"": ""10ef0e9f-e3cf-4797-b4fb-60eaadb3380d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeWeapon3"",
                    ""type"": ""Button"",
                    ""id"": ""3ff4ab5a-422a-4572-a22c-bc5cfd6f5a47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""db893c25-414c-4505-990d-f97980a9653c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""406af9f7-908b-4272-8216-458808d1750d"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""dbe56936-cc91-4d07-9942-d5e3749da6db"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5569aee4-ddbf-4841-8af1-69eac1b78fcc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f4f574f-fffe-4dd4-8dfd-8423ec60cc4e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""155fa40e-5c87-42b0-9eb7-39b7c7a09596"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7201135e-5856-4709-bc94-473733d658b0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bf165a57-a399-4a5e-902e-b642fd4bee5e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b692af65-8fdb-4a8e-8755-2a085487d625"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20638013-d546-48fd-b9a2-33a55ee3c569"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9e5efc6-401b-4582-affd-5bc5ae1053fa"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6af9fda2-aa7c-491a-b4d9-70d6f17fbece"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fc3786c-3191-41a8-9550-2c765c4ac35e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a989029-c116-488d-b0f1-d02c0529a271"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""682289e4-d16c-456d-8c43-6b27f2b27f7a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f4cc687-205e-45f1-b725-ca414af2c559"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39cfa5eb-465a-4731-ab14-4c8826d44f6c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cb62eff-c1f4-4bab-8229-949cef490ae6"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36baf84d-fd90-4af2-8840-69f9c0040504"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""df3c7c0d-6ff3-43b1-90ca-3c70085a46e4"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""c6f21b5b-159c-4779-85a0-b559b4a4f3bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""34f44adb-357d-44e2-bd15-055a79904b4f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // World
            m_World = asset.FindActionMap("World", throwIfNotFound: true);
            m_World_Move = m_World.FindAction("Move", throwIfNotFound: true);
            m_World_Jump = m_World.FindAction("Jump", throwIfNotFound: true);
            m_World_Sprint = m_World.FindAction("Sprint", throwIfNotFound: true);
            m_World_Look = m_World.FindAction("Look", throwIfNotFound: true);
            m_World_Shoot = m_World.FindAction("Shoot", throwIfNotFound: true);
            m_World_Reload = m_World.FindAction("Reload", throwIfNotFound: true);
            m_World_ChangeWeapon1 = m_World.FindAction("ChangeWeapon1", throwIfNotFound: true);
            m_World_ChangeWeapon2 = m_World.FindAction("ChangeWeapon2", throwIfNotFound: true);
            m_World_ChangeWeapon3 = m_World.FindAction("ChangeWeapon3", throwIfNotFound: true);
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
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

        // World
        private readonly InputActionMap m_World;
        private IWorldActions m_WorldActionsCallbackInterface;
        private readonly InputAction m_World_Move;
        private readonly InputAction m_World_Jump;
        private readonly InputAction m_World_Sprint;
        private readonly InputAction m_World_Look;
        private readonly InputAction m_World_Shoot;
        private readonly InputAction m_World_Reload;
        private readonly InputAction m_World_ChangeWeapon1;
        private readonly InputAction m_World_ChangeWeapon2;
        private readonly InputAction m_World_ChangeWeapon3;
        public struct WorldActions
        {
            private @PlayerInputs m_Wrapper;
            public WorldActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_World_Move;
            public InputAction @Jump => m_Wrapper.m_World_Jump;
            public InputAction @Sprint => m_Wrapper.m_World_Sprint;
            public InputAction @Look => m_Wrapper.m_World_Look;
            public InputAction @Shoot => m_Wrapper.m_World_Shoot;
            public InputAction @Reload => m_Wrapper.m_World_Reload;
            public InputAction @ChangeWeapon1 => m_Wrapper.m_World_ChangeWeapon1;
            public InputAction @ChangeWeapon2 => m_Wrapper.m_World_ChangeWeapon2;
            public InputAction @ChangeWeapon3 => m_Wrapper.m_World_ChangeWeapon3;
            public InputActionMap Get() { return m_Wrapper.m_World; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(WorldActions set) { return set.Get(); }
            public void SetCallbacks(IWorldActions instance)
            {
                if (m_Wrapper.m_WorldActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnMove;
                    @Jump.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnJump;
                    @Sprint.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnSprint;
                    @Sprint.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnSprint;
                    @Sprint.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnSprint;
                    @Look.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnLook;
                    @Shoot.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnShoot;
                    @Shoot.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnShoot;
                    @Shoot.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnShoot;
                    @Reload.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnReload;
                    @Reload.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnReload;
                    @Reload.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnReload;
                    @ChangeWeapon1.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon1;
                    @ChangeWeapon1.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon1;
                    @ChangeWeapon1.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon1;
                    @ChangeWeapon2.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon2;
                    @ChangeWeapon2.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon2;
                    @ChangeWeapon2.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon2;
                    @ChangeWeapon3.started -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon3;
                    @ChangeWeapon3.performed -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon3;
                    @ChangeWeapon3.canceled -= m_Wrapper.m_WorldActionsCallbackInterface.OnChangeWeapon3;
                }
                m_Wrapper.m_WorldActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Sprint.started += instance.OnSprint;
                    @Sprint.performed += instance.OnSprint;
                    @Sprint.canceled += instance.OnSprint;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Shoot.started += instance.OnShoot;
                    @Shoot.performed += instance.OnShoot;
                    @Shoot.canceled += instance.OnShoot;
                    @Reload.started += instance.OnReload;
                    @Reload.performed += instance.OnReload;
                    @Reload.canceled += instance.OnReload;
                    @ChangeWeapon1.started += instance.OnChangeWeapon1;
                    @ChangeWeapon1.performed += instance.OnChangeWeapon1;
                    @ChangeWeapon1.canceled += instance.OnChangeWeapon1;
                    @ChangeWeapon2.started += instance.OnChangeWeapon2;
                    @ChangeWeapon2.performed += instance.OnChangeWeapon2;
                    @ChangeWeapon2.canceled += instance.OnChangeWeapon2;
                    @ChangeWeapon3.started += instance.OnChangeWeapon3;
                    @ChangeWeapon3.performed += instance.OnChangeWeapon3;
                    @ChangeWeapon3.canceled += instance.OnChangeWeapon3;
                }
            }
        }
        public WorldActions @World => new WorldActions(this);

        // Menu
        private readonly InputActionMap m_Menu;
        private IMenuActions m_MenuActionsCallbackInterface;
        private readonly InputAction m_Menu_Newaction;
        public struct MenuActions
        {
            private @PlayerInputs m_Wrapper;
            public MenuActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void SetCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public MenuActions @Menu => new MenuActions(this);
        public interface IWorldActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnReload(InputAction.CallbackContext context);
            void OnChangeWeapon1(InputAction.CallbackContext context);
            void OnChangeWeapon2(InputAction.CallbackContext context);
            void OnChangeWeapon3(InputAction.CallbackContext context);
        }
        public interface IMenuActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
    }
}
