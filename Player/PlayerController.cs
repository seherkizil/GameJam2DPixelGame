using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rgb;
    private SpriteRenderer sprite;
    
    [Range(0, 25)]
    [SerializeField] private float movementSpeed;
    [Range(0, 1000)]
    [SerializeField] public float jumpForce;
    [SerializeField] private bool groundCheck;
    private float time;
    void Start()
    {
        //Rgb ayarlar�
        rgb = GetComponent<Rigidbody2D>();
        rgb.gravityScale = 1f; // D���� h�z�n� artt�rd�k.
        rgb.freezeRotation = true; // z ekseninde d�n��� dondurduk.
        rgb.collisionDetectionMode = CollisionDetectionMode2D.Continuous; // Player y�ksek bir yerden d��t���nde di�er objenin i�inden ge�mesin.
        sprite = GetComponent<SpriteRenderer>();
        groundCheck = true;
        
    }

    // Update is called once per frame
    void Update()
    {
      
        Move();
        Jump();

        if (jumpForce == 300||jumpForce==0)
        {
            time+= Time.deltaTime;
            if (time>=4)
            {
                jumpForce = 230;
                time= 0;
            }
        }
    }
    
    private void Move()
    {
        // Karakteri x ekseninde hareket ettirme
        float hAxis = Input.GetAxis("Horizontal");

        rgb.velocity = new Vector2(hAxis * movementSpeed, rgb.velocity.y); // x y�n�nde speed kadar, y y�n�nde o anki sahip oldu�u h�z kadar h�zlans�n.

        // Karakterin y�n�n� d�nd�rme
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            sprite.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sprite.flipX = true;
        }

    }
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) &&groundCheck)
        {
           rgb.AddForce(new Vector2(0, jumpForce)); // �leriye do�ru giderken z�plat�yor.

        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            groundCheck= true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            groundCheck = false;
        }
    }
  
}
