using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneLoadManager", menuName = "Managers/SceneLoadManager")]
public class SceneLoadManager : ScriptableObject
{
    [SerializeField]
    private SceneLoader sceneLoader;
    SceneLoadManager()
    {

    }

    public SceneLoader SceneLoader { get => sceneLoader; set => sceneLoader = value; }

    private void Awake()
    {
        SceneLoader = new SceneLoader();
    }
}
