using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponIconCanvas : MonoBehaviour
{
    [SerializeField] private GameObject weapon1Image,weapon2Image;
   
    void Start()
    {
        weapon1Image.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapon1Image.SetActive(true);
            weapon2Image.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        { 
            weapon1Image.SetActive(false);
            weapon2Image.SetActive(true);
        }
    }
}
