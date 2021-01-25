using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour 
{
	public int damageToGive = 1;
	public void SendDamage (int dam)
	{
		// PlayerHealth playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		// playerStats.TakeDamage(dam);
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Vector3 hitDirection = other.transform.position - transform.position;
			hitDirection = hitDirection.normalized;

			FindObjectOfType<HealthSystem>().HurtPlayer(damageToGive, hitDirection);
		}
	}
}
