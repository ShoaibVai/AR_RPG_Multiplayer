//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.0
//     from Assets/Scripts/InputActions/PlayerControlsInputAction.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Scripts/InputActions/PlayerControlsInputAction.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControlsInputAction: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControlsInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlsInputAction"",
    ""maps"": [
        {
            ""name"": ""PlayerControlsMap"",
            ""id"": ""1594d374-4fd7-4886-a0d9-d53b60eccf31"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b1c67e55-b743-4ed8-91eb-1894181f8229"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""ca3e93fa-85ab-42f1-8a51-cd1867f5e95b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootAngle"",
                    ""type"": ""Value"",
                    ""id"": ""01b5407d-7fb8-4dd9-bccd-04619582792d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6e31f0e1-af24-4715-ac52-51af28582851"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""57e3f358-2236-4876-8def-fc966663d8ed"",
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
                    ""id"": ""c6aa18cb-0f75-4ef4-bced-2f773e0b3092"",
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
                    ""id"": ""2e887439-235c-401f-800d-a774be9ad942"",
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
                    ""id"": ""8b75cc17-aac7-406d-9b28-e5b53fed3574"",
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
                    ""id"": ""2cb03d6b-ed7f-4e68-8f81-2038bf26b902"",
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
                    ""id"": ""e8ded6e0-d9d5-471d-a662-2c11dd67ea68"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a60d154-95da-44ad-b922-b5cada573ca5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootAngle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControlsMap
        m_PlayerControlsMap = asset.FindActionMap("PlayerControlsMap", throwIfNotFound: true);
        m_PlayerControlsMap_Move = m_PlayerControlsMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerControlsMap_Shoot = m_PlayerControlsMap.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControlsMap_ShootAngle = m_PlayerControlsMap.FindAction("ShootAngle", throwIfNotFound: true);
    }

    ~@PlayerControlsInputAction()
    {
        UnityEngine.Debug.Assert(!m_PlayerControlsMap.enabled, "This will cause a leak and performance issues, PlayerControlsInputAction.PlayerControlsMap.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerControlsMap
    private readonly InputActionMap m_PlayerControlsMap;
    private List<IPlayerControlsMapActions> m_PlayerControlsMapActionsCallbackInterfaces = new List<IPlayerControlsMapActions>();
    private readonly InputAction m_PlayerControlsMap_Move;
    private readonly InputAction m_PlayerControlsMap_Shoot;
    private readonly InputAction m_PlayerControlsMap_ShootAngle;
    /// <summary>
    /// Provides access to input actions defined in input action map "PlayerControlsMap".
    /// </summary>
    public struct PlayerControlsMapActions
    {
        private @PlayerControlsInputAction m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public PlayerControlsMapActions(@PlayerControlsInputAction wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "PlayerControlsMap/Move".
        /// </summary>
        public InputAction @Move => m_Wrapper.m_PlayerControlsMap_Move;
        /// <summary>
        /// Provides access to the underlying input action "PlayerControlsMap/Shoot".
        /// </summary>
        public InputAction @Shoot => m_Wrapper.m_PlayerControlsMap_Shoot;
        /// <summary>
        /// Provides access to the underlying input action "PlayerControlsMap/ShootAngle".
        /// </summary>
        public InputAction @ShootAngle => m_Wrapper.m_PlayerControlsMap_ShootAngle;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_PlayerControlsMap; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="PlayerControlsMapActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(PlayerControlsMapActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="PlayerControlsMapActions" />
        public void AddCallbacks(IPlayerControlsMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @ShootAngle.started += instance.OnShootAngle;
            @ShootAngle.performed += instance.OnShootAngle;
            @ShootAngle.canceled += instance.OnShootAngle;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="PlayerControlsMapActions" />
        private void UnregisterCallbacks(IPlayerControlsMapActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @ShootAngle.started -= instance.OnShootAngle;
            @ShootAngle.performed -= instance.OnShootAngle;
            @ShootAngle.canceled -= instance.OnShootAngle;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="PlayerControlsMapActions.UnregisterCallbacks(IPlayerControlsMapActions)" />.
        /// </summary>
        /// <seealso cref="PlayerControlsMapActions.UnregisterCallbacks(IPlayerControlsMapActions)" />
        public void RemoveCallbacks(IPlayerControlsMapActions instance)
        {
            if (m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="PlayerControlsMapActions.AddCallbacks(IPlayerControlsMapActions)" />
        /// <seealso cref="PlayerControlsMapActions.RemoveCallbacks(IPlayerControlsMapActions)" />
        /// <seealso cref="PlayerControlsMapActions.UnregisterCallbacks(IPlayerControlsMapActions)" />
        public void SetCallbacks(IPlayerControlsMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="PlayerControlsMapActions" /> instance referencing this action map.
    /// </summary>
    public PlayerControlsMapActions @PlayerControlsMap => new PlayerControlsMapActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "PlayerControlsMap" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="PlayerControlsMapActions.AddCallbacks(IPlayerControlsMapActions)" />
    /// <seealso cref="PlayerControlsMapActions.RemoveCallbacks(IPlayerControlsMapActions)" />
    public interface IPlayerControlsMapActions
    {
        /// <summary>
        /// Method invoked when associated input action "Move" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Shoot" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnShoot(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "ShootAngle" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnShootAngle(InputAction.CallbackContext context);
    }
}
