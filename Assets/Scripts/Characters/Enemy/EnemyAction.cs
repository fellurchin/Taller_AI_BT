using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAction : Task
{
    [SerializeField] protected Enemy enemy;
    [SerializeField] protected bool stopped;
    public override bool Execute()
    {
        return SetAction();
    }

    protected abstract bool SetAction();
}
