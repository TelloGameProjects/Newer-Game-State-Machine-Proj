using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    [SerializeField] private AppManager stateMachine;
    [SerializeField] private GameObject mainMenuManager;
    [SerializeField] private GameObject playingManager;
    [SerializeField] private GameObject pauseManager;
    [SerializeField] private GameObject gameOverManager;

    [SerializeField] private MainMenuStateAsset mainMenuState;
    [SerializeField] private PlayingStateAsset playingState;
    [SerializeField] private PauseStateAsset pauseState;
    [SerializeField] private GameOverStateAsset gameOverState;


    // Start is called before the first frame update
    void Start()
    {
        if(mainMenuManager.tag == "MainMenuManager")
        {
            mainMenuManager.SetActive(true);
            stateMachine.AppStateMachine.ChangeState(mainMenuState.StateObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
