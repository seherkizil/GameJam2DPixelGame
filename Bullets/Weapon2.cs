using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    private PlayerController character;
    private PlayerHealth playerHealth;
    private EnemyHealth enemyHealth;
    
    
    void Start()
    {
        StartCoroutine(spellTime());
        character=GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        playerHealth= GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        enemyHealth= GameObject.FindWithTag("Enemy").GetComponent<EnemyHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0.01f, 0, 0);
    }
    IEnumerator spellTime()
    {

        yield return new WaitForSeconds(2.2f);
        Destroy(gameObject);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().color == Color.blue)
            {
                character.jumpForce = 300;
                enemyHealth.currentHealth -= 1;
                Destroy(gameObject);

            }
            else if (collision.gameObject.GetComponent<SpriteRenderer>().color == Color.red)
            {
                playerHealth.currentHealth -= 1;
                enemyHealth.currentHealth -= 1;
                Destroy(gameObject);
            }
            else if (collision.gameObject.GetComponent<SpriteRenderer>().color == Color.yellow)
            {
                character.jumpForce = 0;
                enemyHealth.currentHealth -= 1;
                Destroy(gameObject);
            }
            else if (collision.gameObject.GetComponent<SpriteRenderer>().color == Color.green)
            {
                playerHealth.currentHealth += 1;
                enemyHealth.currentHealth -= 1;
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }





}
