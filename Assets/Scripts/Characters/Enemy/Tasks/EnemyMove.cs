using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : EnemyAction
{
    [SerializeField] private Transform player;
    [SerializeField] private bool running;

    private float speed;
    private void Awake()
    {
        if (enemy == null) enemy = GetComponent<Enemy>();
        speed = running ? enemy.MyAttributes.RunSpeed : enemy.MyAttributes.WalkSpeed;
    }

    protected override bool SetAction()
    {
        enemy.Agent.isStopped = stopped;
        enemy.Agent.speed = speed;
        enemy.Agent.destination = player.position;
        return true;
    }
}