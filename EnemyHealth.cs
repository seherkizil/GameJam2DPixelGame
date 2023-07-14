using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    [SerializeField] public int currentHealth;
    void Start()
    {
        currentHealth = Random.Range(2, 8);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) 
        {
        Destroy(gameObject);
        }
    }
   
}
