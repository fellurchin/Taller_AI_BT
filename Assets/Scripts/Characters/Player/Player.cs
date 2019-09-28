using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ICharacter
{
    [SerializeField] private CharacterAttributes myAttributes;
    public CharacterAttributes MyAttributes => myAttributes;

    public delegate void PlayerDelegate(CharacterHealth enemyHealth);

    public event PlayerDelegate EnemyEntersEvent;
    public event PlayerDelegate EnemyLeavesEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyEntersEvent?.Invoke(other.GetComponent<CharacterHealth>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyLeavesEvent?.Invoke(other.GetComponent<CharacterHealth>());
        }
    }
}