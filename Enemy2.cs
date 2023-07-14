using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float distance;
    private bool movingRight = true;
    [SerializeField] Transform groundDetection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider==false)
        {
            {
                if (movingRight==true)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                    movingRight= false;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true ;
                }
            }

        }
    }
}
