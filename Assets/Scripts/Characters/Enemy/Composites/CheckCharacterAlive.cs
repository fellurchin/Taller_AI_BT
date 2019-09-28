using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CheckCharacterAlive : Selector
{
    [SerializeField] private CharacterHealth characterHealth;
    protected override bool CheckCondition()
    {
        return characterHealth.IsAlive;
    }
}
