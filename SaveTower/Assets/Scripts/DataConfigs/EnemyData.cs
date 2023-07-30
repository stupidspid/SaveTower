using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "InstanceData/EnemyData")]
public class EnemyData : ScriptableObject
{
    public List<Enemy> enemies;
}

[Serializable]
public struct Enemy
{
    public int lifeAmount;
    public float moveSpeed;
    public Sprite icon;
    public EnemyType enemyType;
}

public enum EnemyType
{
    NONE = 0,
    WARRIOR = 1,
    NINJA = 2,
}
