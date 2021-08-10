using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class PlayStateManager : MonoBehaviour
{
    [SerializeField] private GameStateManager stateManager;

    [SerializeField] private PlayingStateAsset playingState;


    // Start is called before the first frame update
    void Start()
    {
        stateManager.StateMachine.AppStateMachine.AddState(playingState.StateObject);
        stateManager.StateMachine.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in Playing State
        if (newState == playingState.StateObject)
        {
            Debug.Log("Hello from PlayInitializer.CheckChangedState()!");
        }
    }
}
