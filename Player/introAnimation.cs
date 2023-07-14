using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introAnimation : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private bool isSleep,isRun;
    [SerializeField] private GameObject text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isRun)
        {
            anim.SetBool("isRun", true);
        }
        else
        {
            anim.SetBool("isRun", false);
        }
        if (isSleep)
        {
            anim.SetBool("isSleep", true);
        }
        else
        {
            anim.SetBool("isSleep", false);
        }
       
    }
}
