using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject fade;
    [SerializeField] private GameObject timeLine;
    [SerializeField] private GameObject optionsPanel;
    [Header("Buttons")]
    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject optionsButton;
    [SerializeField] private GameObject quitButton;
    void Start()
    {
        fade.GetComponent<Image>().DOColor(new Color32(0, 0, 0, 0), 2).OnComplete(
            () =>
            {
                fade.SetActive(false);
                timeLine.SetActive(true);
            });
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenOptionsPanel()
    {
        optionsPanel.SetActive(true);
        startButton.SetActive(false);
        quitButton.SetActive(false);
        optionsButton.SetActive(false);
        optionsPanel.transform.DOScale(new Vector3(0.779039979f, 0.779039979f, 0.779039979f), 1);
    }
    public void BackToMainMenu()
    {
        optionsPanel.transform.DOScale(new Vector3(0.01f, 0.01f, 0.01f), 1).OnComplete(
            () =>
            {
                optionsPanel.SetActive(false);
                startButton.SetActive(true);
                quitButton.SetActive(true);
                optionsButton.SetActive(true);
            });
       
    }
   
}
