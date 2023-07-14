using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator playerAnim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.LeftArrow))
        {
            AnimationCheck();
            playerAnim.SetBool("isRun",true);
           
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            AnimationCheck();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AnimationCheck();
            playerAnim.SetBool("isJump",true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            AnimationCheck();
        }
        if (Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W) ||Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) ||Input.GetKey(KeyCode.UpArrow)&&Input.GetKey(KeyCode.RightArrow)
            ||Input.GetKey(KeyCode.LeftArrow)&&Input.GetKey(KeyCode.UpArrow)
            )
        {
            
            AnimationCheck();
            playerAnim.SetBool("isUpperCross",true);
            
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            AnimationCheck();
            playerAnim.SetBool("isFiring",true);
            
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            AnimationCheck();
        }
        
    }

    private void AnimationCheck()
    {
        playerAnim.SetBool("isRun",false);
        playerAnim.SetBool("isJump", false);
        playerAnim.SetBool("isUpperCross",false);
        playerAnim.SetBool("isFiring", false);
    }
}
