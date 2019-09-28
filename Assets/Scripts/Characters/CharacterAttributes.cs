using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterAttributes
{
	[SerializeField] private float startingHealth = 100f, walkSpeed = 5f, runSpeed = 10f, damage;

	public float StartingHealth => startingHealth;
	public float WalkSpeed => walkSpeed;
	public float RunSpeed => runSpeed;
	public float Damage => damage;
}