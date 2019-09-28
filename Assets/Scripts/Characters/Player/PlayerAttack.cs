using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private List<CharacterHealth> enemiesOnRange = new List<CharacterHealth>();
    private Player player;
    private float damage = 0f;

    private void Awake()
    {
        player = GetComponent<Player>();
        if (player == null) return;
        damage = player.MyAttributes.Damage;
        player.EnemyEntersEvent += AddEnemy;
        player.EnemyLeavesEvent += RemoveEnemy;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackEnemiesOnRange(damage);
        }
    }

    private void AttackEnemiesOnRange(float damage)
    {
        for (int i = 0; i < enemiesOnRange.Count; i++)
        {
            enemiesOnRange[i].ModifyHealth(-damage);
        }
    }

    private void AddEnemy(CharacterHealth health)
    {
        enemiesOnRange.Add(health);
    }

    private void RemoveEnemy(CharacterHealth health)
    {
        enemiesOnRange.Remove(health);
    }
}