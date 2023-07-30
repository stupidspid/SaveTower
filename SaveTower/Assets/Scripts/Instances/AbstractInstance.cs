using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public abstract class AbstractInstance : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;
    [SerializeField] private EnemyType enemyType;

    private float _speed;
    private int _lifeAmount;
    private Sprite _icon;
    private CastleInstance _castleInstance;
    
    [Inject]
    private void Init(CastleInstance castleInstance)
    {
        _castleInstance = castleInstance;
    }

    private void Start()
    {
        GetEnemiesData();
    }

    private void GetEnemiesData()
    {
        var newWarriorData = enemyData.enemies.FirstOrDefault(x => x.enemyType == enemyType);
        _speed = newWarriorData.moveSpeed;
        _lifeAmount = newWarriorData.lifeAmount;
        _icon = newWarriorData.icon;
    }

    private void Move()
    {
        transform.Translate(_castleInstance.transform.position * Time.deltaTime * _speed);
    }

    private void Update()
    {
        Move();
    }

    public class Factory : PlaceholderFactory<AbstractInstance> { }
}
