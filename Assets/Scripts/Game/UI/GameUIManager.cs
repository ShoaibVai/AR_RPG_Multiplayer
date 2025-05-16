using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] private Canvas CreateGameCanvas;
    [SerializeField] private Canvas ControllerCanvas;
    [SerializeField] private Canvas RestartQuitCanvas;

    // Start is called before the first frame update
    void Start()
    {
        ShowCreateGameCanvas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ShowCreateGameCanvas()
    {
        CreateGameCanvas.gameObject.SetActive(true);
        ControllerCanvas.gameObject.SetActive(false);
        RestartQuitCanvas.gameObject.SetActive(false);
    }
    
}
