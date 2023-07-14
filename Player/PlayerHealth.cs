using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
   // public GameObject healthbar;
    [SerializeField] private int maxHealth = 3;
    [SerializeField] public int currentHealth;
    [SerializeField] private GameObject heart1, heart2, heart3;

    void Start()
    {
        currentHealth = maxHealth;
        HealthCheck();
       // healthbar.GetComponent<Health>().SetHealth(currentHealth);
    }
    private void Update()
    {
        if (currentHealth>3)
        {
            currentHealth = 3;
        }
        if(currentHealth==3)
        {
            HealthCheck();
        }
        if (currentHealth==2)
        {
            HealthCheck();
            heart3.SetActive(false);
        }
        if (currentHealth==1) 
        {
            HealthCheck();
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        if (currentHealth==0)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            Die();
        }
    }

    void Die()
    {

        Scene level = SceneManager.GetActiveScene();
        SceneManager.LoadScene(level.name); // Hangi leveldaysan o level� al�p y�kler.
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeadZone")) 
        {
            Die();
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentHealth = currentHealth - 1;
        }
    }
    void HealthCheck()
    {
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
    }
    
}
