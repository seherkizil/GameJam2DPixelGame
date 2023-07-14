using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorfulBullet : MonoBehaviour
{
    int sayi;
    public int damageno;
    void Start()
    {
        // rastgele renk ataması
        StartCoroutine(spellTime());
        sayi = Random.Range(1, 5);
        if (sayi == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(0,0,255,65);
        }
        if (sayi == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 65);
        }
        if (sayi == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(235, 235,4, 65);
        }
        if (sayi == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 217, 0, 255);
        }
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
        //Düşmanların rengini değiiştirme
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (sayi == 1)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                Destroy(gameObject);
            }
            else if (sayi == 2)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                Destroy(gameObject);
            }
            else if (sayi == 3)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
                Destroy(gameObject);
            }
            else if (sayi == 4)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                Destroy(gameObject);
            }

        }
    }

}
