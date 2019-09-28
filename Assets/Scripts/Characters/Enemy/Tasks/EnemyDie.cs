using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : EnemyAction
{
    [SerializeField] private Color deadColor;

    private Renderer renderer;
    private bool dead = false;

    private void Awake()
    {
        if (enemy == null) enemy = GetComponent<Enemy>();
        renderer = GetComponent<Renderer>();
    }

    protected override bool SetAction()
    {
        enemy.Agent.isStopped = stopped;
        if (dead) return true;
        renderer.material.color = deadColor;
        dead = true;
        return true;
    }
}