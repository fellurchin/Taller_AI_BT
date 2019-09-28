using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistToAct : Selector
{
    [SerializeField] private float distToAct;
    [SerializeField] private Transform player;

    protected override bool CheckCondition()
    {
        float distance = (TargetAI.transform.position - player.position).magnitude;
        return distance <= distToAct;
    }
}