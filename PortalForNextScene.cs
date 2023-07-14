using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PortalForNextScene : MonoBehaviour
{
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject fade;
    [SerializeField] private bool fadeControl = false, loadScene = false;
    private float time = 0;
    void Start()
    {
        //fade.GetComponent<Image>().DOColor(new Color32(0, 0, 0, 255), 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeControl)
        {
            time+= Time.deltaTime;
            fade.GetComponent<Image>().DOColor(new Color32(0, 0, 0, 255), 3);
            if (time>=3)
            {
                loadScene = true;
            }
        }
        if (loadScene)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
           
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            character.transform.DOMove(new Vector3(62.873f, -3.472f, 15.102f), 1);
            character.transform.DOScale(new Vector3(0, 0, 0), 1);
            fadeControl= true;
            
        }
    }
}
