using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu(fileName = "MainMenuManager", menuName = "Managers/MainMenuManager")]
public class MainMenuManager : ScriptableObject
{
    [SerializeField]
    private StateMachine appStateMachine;

    private void OnEnable()
    {
        Debug.Log("Hello from MainMenuManager.OnEnable()!");
    }
}