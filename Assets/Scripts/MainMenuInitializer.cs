using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class MainMenuInitializer : MonoBehaviour
{
    // ScriptableObject containing a Vast.StateMachine.StateMachine()
    [SerializeField] private AppManager managingParent;

    [SerializeField] private MainMenuState menuState;

    

    // Start is called before the first frame update
    void Start()
    {
        managingParent.AppStateMachine.AddState(menuState.MenuState);
        managingParent.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in MainMenu
        if(newState == menuState.MenuState)
        {
            Debug.Log("Hello from MainMenuInitializer.CheckChangedState()!");
            //TODO activate relevant GameObject(s)
        }
    }
}
