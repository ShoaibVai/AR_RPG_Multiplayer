using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitGame : NetworkBehaviour
{
    [SerializeField] private Button QuitGameButton;
    
    // Start is called before the first frame update
    void Start()
    {
        QuitGameButton.onClick.AddListener(() =>
        {
            RequestServerToQuitGameServerRpc();
        });
    }
    
    [ServerRpc(RequireOwnership = false)]
    void RequestServerToQuitGameServerRpc()
    {
        string currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        // Load the current scene using the NetworkManager
        NetworkManager.Singleton.SceneManager.LoadScene(currentSceneName, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

}
