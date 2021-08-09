using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class MainMenuInitializer : MonoBehaviour
{
    // ScriptableObject containing a Vast.StateMachine.StateMachine()
    [SerializeField] private AppManager managingParent;

    [SerializeField] private MainMenuStateAsset menuState;

    private void OnEnable()
    {
        managingParent.AppStateMachine.AddState(menuState.StateObject);
        managingParent.AppStateMachine.OnStateChange += CheckChangedState;
        Debug.Log("MainMenuState added to AppStateMachine");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in MainMenu
        if(newState == menuState.StateObject)
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
