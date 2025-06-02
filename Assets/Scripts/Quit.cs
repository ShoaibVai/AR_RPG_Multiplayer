using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitButton : NetworkBehaviour
{
    [SerializeField] private Button _QuitButton;
    
    // Start is called before the first frame update
    void Start()
    {
        _QuitButton.onClick.AddListener(() =>
        {
            RequestServerToQuitGameServerRpc();
        });
    }
    
    [ServerRpc(RequireOwnership = false)]
    void RequestServerToQuitGameServerRpc()
    {
        Application.Quit();
    }

}
