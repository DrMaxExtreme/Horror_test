using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class SpawnPlayer : MonoBehaviour, ISceneLoadHandler<LevelConfig>
{
    public void OnSceneLoaded(LevelConfig argument)
    {
        Debug.Log(argument.PlayerHealth);
    }
}
