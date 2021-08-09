using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainMenuState", menuName = "States/MainMenuState")]
public class MainMenuState : ScriptableObject
{
    private SplashScreenState stateObject;

    MainMenuState()
    {
        stateObject = new SplashScreenState();
        Debug.Log("Hello from MainMenuState()");
    }

    public SplashScreenState StateObject { get => stateObject; set => stateObject = value; }
}
