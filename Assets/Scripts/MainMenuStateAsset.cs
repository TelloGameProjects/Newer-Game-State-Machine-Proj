using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainMenuState", menuName = "States/MainMenuState")]
public class MainMenuStateAsset : ScriptableObject
{
    private SplashScreenState stateObject;

    MainMenuStateAsset()
    {
        StateObject = new SplashScreenState();
        Debug.Log("Hello from MainMenuStateAsset()");
    }

    public SplashScreenState StateObject { get => stateObject; set => stateObject = value; }
}
