using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
	private ICharacter character;
	private float currentHealth;

	public  bool IsAlive
	{
		get { return currentHealth > 0; }
	}

	private void Start()
	{
		character = GetComponent<ICharacter>();
		currentHealth = character.MyAttributes.StartingHealth;
	}

	public void ModifyHealth(float amount)
	{
		currentHealth += amount;
		currentHealth = Mathf.Clamp(currentHealth, 0, character.MyAttributes.StartingHealth);
		
		Debug.Log($"The current health of {name} is {currentHealth}");
	}
}