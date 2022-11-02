using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelConfig", menuName = "Create Level Config")]
public class LevelConfig : ScriptableObject
{
    [SerializeField] private int _playerHealth;

    public int PlayerHealth => _playerHealth;
}
