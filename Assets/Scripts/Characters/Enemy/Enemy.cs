using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, ICharacter
{
    [SerializeField] protected CharacterAttributes myAttributes;
    [SerializeField] protected Root root;
    [SerializeField] protected NavMeshAgent agent;
    public CharacterAttributes MyAttributes => myAttributes;
    public NavMeshAgent Agent => agent;

    protected void Awake()
    {
        if (root == null) root = GetComponent<Root>();
        if (agent == null) agent = GetComponent<NavMeshAgent>();
    }

    protected void Update()
    {
        if (root != null)
        {
            root.Execute();
        }
    }
}