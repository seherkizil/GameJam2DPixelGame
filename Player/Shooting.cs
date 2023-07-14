using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   [SerializeField] private GameObject character;
    [SerializeField] private GameObject weapon1,weapon2;
    [SerializeField] private Transform right, left, upperRight, upperLeft;
    private Transform temporaryLoc;
    private bool weaponControl;
    void Start()
    {
        weaponControl= true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponControl = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        { weaponControl = false; }

        
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (weaponControl)
            {
                spawnLocation();
                Instantiate(weapon1, temporaryLoc.position, temporaryLoc.rotation);
            }
            else
            {
                spawnLocation();
                Instantiate(weapon2, temporaryLoc.position, temporaryLoc.rotation);
            }
        }

       
    }
    void spawnLocation()
    {
        if (character.gameObject.GetComponent<SpriteRenderer>().flipX == true)
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                temporaryLoc = upperLeft;

            }
            else
            {
                temporaryLoc = left;
              
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                temporaryLoc = upperRight;

            }
            else
            {
                temporaryLoc = right;
            }

        }
    }
}
