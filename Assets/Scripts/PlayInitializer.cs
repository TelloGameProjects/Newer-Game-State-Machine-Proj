using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class PlayInitializer : MonoBehaviour
{
    [SerializeField] private AppManager managingParent;

    private PlayingState playingState;


    // Start is called before the first frame update
    void Start()
    {
        playingState = (PlayingState)(managingParent.AppStateMachine.AddState(new PlayingState()));
        managingParent.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in Playing State
        if (newState == playingState)
        {
            Debug.Log("Hello from PlayInitializer.CheckChangedState()!");
        }
    }
}
