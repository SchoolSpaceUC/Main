using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HealthSystem : MonoBehaviour 
{
	public int maxHealth;
	public int currentHealth;

	public PlayerController thePlayer;
	//public event EventHandler OnHealthChanged;
	//private int health;
	//private int healthMax;

	//public HealthSystem(int healthMax)
	//   {
	//	this.healthMax = healthMax;
	//	health = healthMax;
	//   }

	//public int GetHealth()
	//   {
	//	return health;
	//   }

	//public float GetHealthPercent()
	//   {
	//	return (float)health / healthMax;
	//   }
	void Start()
	{
		currentHealth = maxHealth;

		thePlayer = FindObjectOfType<PlayerController>();
	}

	void Update()
	{
		
	}

	public void HurtPlayer(int damage, Vector3 direction)
	{
		currentHealth -= damage;

		if (currentHealth < 0)
		{
			currentHealth = 0;
		}

		thePlayer.Knockback(direction);
	}


	//public void Damage(int damageAmount)
	//{
	//	health -= damageAmount;
	//	Debug.Log("Health = " + health.ToString());
	//	if (health < 0) health = 0;
	//	if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
	//}
	public void HealPlayer(int healAmount)
	{
		currentHealth += healAmount;

		if (currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}
	}
	//public void Heal(int healAmount)
	//   {
	//	health += healAmount;
	//	if (health > healthMax) health = healthMax;
	//	if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
	//}
}
