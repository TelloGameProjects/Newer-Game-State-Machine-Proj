using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoSingleton<StateManager>
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


    private void Awake()
    {
        Debug.Log("SceneInitializer.Awake() called");
        if (mainMenuManager.tag == "MainMenuManager")
        {
            mainMenuManager.SetActive(true);
            Debug.Log("mainMenuManager.SetActive(true);");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if(mainMenuState.StateObject != null)
        {
            Debug.Log(mainMenuState.StateObject);
                
            if(stateMachine.AppStateMachine.ContainsState(mainMenuState.StateObject))
            {
                Debug.Log("stateMachine DOES contain mainMenuState.StateObject");
                stateMachine.AppStateMachine.ChangeState(mainMenuState.StateObject);
            }
            else
            {
                Debug.Log("stateMachine DOES NOT contain mainMenuState.StateObject");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
