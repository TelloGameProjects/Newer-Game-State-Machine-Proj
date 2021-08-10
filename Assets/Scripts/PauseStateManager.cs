using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class PauseStateManager : MonoBehaviour
{
    [SerializeField] private StateManager stateManager;
    [SerializeField] private PauseStateAsset pauseStateAsset;

    


    // Start is called before the first frame update
    void Start()
    {
       stateManager.StateMachine.AppStateMachine.AddState(pauseStateAsset.StateObject);
       stateManager.StateMachine.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in Playing State
        if (newState == pauseStateAsset.StateObject)
        {
            Debug.Log("Hello from PlayInitializer.CheckChangedState()!");
        }
    }
}
