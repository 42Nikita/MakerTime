using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    public int damage = 10;
    public int health = 100;
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;
         UpdateHealthUI();
        
    }
    public void Die()
    {
        Debug.Log("ти падох");
        
    }
    void OnTrigerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage(damage);
        }
    }
    private void UpdateHealthUI()
    {
        healthText.text = "Health: " + health.ToString(); 
    }

    // Update is called once per frame
    
}
