using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : EnemyAction
{
    [SerializeField] private CharacterHealth playerHealth;
    [SerializeField] private float timeBetweenAttacks = 3f;

    private bool canAttack = true;
    private float damage;

    private void Awake()
    {
        if (enemy == null) enemy = GetComponent<Enemy>();
        damage = enemy.MyAttributes.Damage;
    }

    protected override bool SetAction()
    {
        if (!canAttack) return true;
        canAttack = false;
        playerHealth.ModifyHealth(-damage);
        StartCoroutine(AttackDelay(timeBetweenAttacks));
        return true;
    }

    private IEnumerator AttackDelay(float delay)
    {
        yield return  new WaitForSeconds(delay);
        canAttack = true;
    }
}