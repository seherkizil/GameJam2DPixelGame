using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour
{
    [SerializeField] private GameObject telescopeTimeline;
    [SerializeField] private bool control=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (control&&Input.GetKeyDown(KeyCode.E))
            {
                telescopeTimeline.SetActive(true);
            }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            control= true;
            
        }
    }
}
