using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainMenuState", menuName = "States/MainMenuState")]
public class MainMenuState : ScriptableObject
{
    private SplashScreenState menuState;

    MainMenuState()
    {
        menuState = new SplashScreenState();
        Debug.Log("Hello from MainMenuState()");
    }

    public SplashScreenState MenuState { get => menuState; set => menuState = value; }
}
