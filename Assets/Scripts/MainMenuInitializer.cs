using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class MainMenuInitializer : MonoBehaviour
{
    // ScriptableObject containing a Vast.StateMachine.StateMachine()
    [SerializeField] private AppManager managingParent;

    // Create the state object here, then give to AppManager
    private SplashScreenState splashScreenState;
    private bool isActive;
    

    // Start is called before the first frame update
    void Start()
    {
        splashScreenState = (SplashScreenState)(managingParent.AppStateMachine.AddState(new SplashScreenState()));
        managingParent.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in MainMenu
        if(newState == splashScreenState)
        {
            Debug.Log("Hello from MainMenuInitializer.CheckChangedState()!");
            //TODO activate relevant GameObject(s)
        }
    }
}
