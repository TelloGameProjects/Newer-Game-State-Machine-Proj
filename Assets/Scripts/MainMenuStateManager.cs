using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vast.StateMachine;

public class MainMenuStateManager : MonoBehaviour
{

    [SerializeField] private GameStateManager stateManager;

    [SerializeField] private MainMenuStateAsset menuState;

    public MainMenuStateAsset MenuState { get => menuState; set => menuState = value; }

    private void OnEnable()
    {
        stateManager.StateMachine.AppStateMachine.AddState(MenuState.StateObject);
        stateManager.StateMachine.AppStateMachine.OnStateChange += CheckChangedState;
        Debug.Log("MainMenuState added to AppStateMachine");
    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in MainMenu
        if(newState == MenuState.StateObject)
        {
            Debug.Log("Hello from MainMenuInitializer.CheckChangedState()!");
            //TODO activate relevant GameObject(s)
            ActivateStateObjects();
        }
    }

    void ActivateStateObjects()
    {
        foreach (Transform child in transform)
            child.gameObject.SetActive(true);
    }
}
