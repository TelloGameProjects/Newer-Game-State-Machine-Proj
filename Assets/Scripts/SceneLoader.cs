using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader
{
    public enum Scene           // Note: Spelling of enum fields matter
    {
        MainMenuScene, 
        PlayingScene, 
        PausingScene, 
        GameOverScene
    }

    public void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
