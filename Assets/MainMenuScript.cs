using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private Button OnlineMode;
    [SerializeField] private Button OfflineMode;
    [SerializeField] private Button ExitGame;

    // Start is called before the first frame update
    void Start()
    {
        OnlineMode.onClick.AddListener(() => SceneManager.LoadScene("Online"));
        OfflineMode.onClick.AddListener(() => SceneManager.LoadScene("Offline"));
        ExitGame.onClick.AddListener(() => Application.Quit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
