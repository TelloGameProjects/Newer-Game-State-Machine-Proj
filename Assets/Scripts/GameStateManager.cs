using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoSingleton<GameStateManager>
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

    [SerializeField] private StartButton mainMenuStartButton;

    public AppManager StateMachine { get => stateMachine; set => stateMachine = value; }
    public StartButton MainMenuStartButton { get => mainMenuStartButton; set => mainMenuStartButton = value; }

    private void Awake()
    {
        //Debug.Log("SceneInitializer.Awake() called");
        if (mainMenuManager.tag == "MainMenuManager")
        {
            mainMenuManager.SetActive(true);
            
           // Debug.Log("mainMenuManager.SetActive(true);");
        }
    }


    // Start is called before the first frame update
    void Start()
    {


        if (mainMenuState.StateObject != null)
        {
            
                
            if(StateMachine.AppStateMachine.ContainsState(mainMenuState.StateObject))
            {
                //Debug.Log("stateMachine DOES contain mainMenuState.StateObject");
                StateMachine.AppStateMachine.ChangeState(mainMenuState.StateObject);
                MainMenuStartButton.StartButtonControl.clickable.clicked += TransitionToPlayState;
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

    void TransitionToPlayState()
    {
        playingManager.SetActive(true);
        if (StateMachine.AppStateMachine.ContainsState(playingState.StateObject))
        {
            //Debug.Log("StateMachine DOES contain playing state... transitioning now.");
            StateMachine.AppStateMachine.ChangeState(playingState.StateObject);
            mainMenuManager.SetActive(false);
        }
        else
        {
            //Debug.Log("StateMachine DOES NOT contain playing state... not transitioning now.");
            playingManager.SetActive(false);
        }
     
    }
}
