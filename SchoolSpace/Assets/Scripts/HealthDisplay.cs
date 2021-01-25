using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{ 

    //private int health = 5;
    public Text healthText;


    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + FindObjectOfType<HealthSystem>().currentHealth;

        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            FindObjectOfType<HealthSystem>().currentHealth--;
        }
    }
}
