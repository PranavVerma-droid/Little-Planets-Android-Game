using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject victoryPanel;


    public Text timerDisplay;
    private bool aslost;

    public float timer;

    private bool aswinning;

   
    public AudioSource source2;
    
    private void Update() {
        if (aslost == false) {
            timerDisplay.text = timer.ToString("F0");
        }

        if (timer <= 0) {
            if (aslost == true) {

            } else {
                victoryPanel.SetActive(true);
            }
        } else {
            timer -= Time.deltaTime;
        }
        
        
    }


    public void GameOver(){
        aslost = true;
        Invoke("Delay", 1.5f);
        source2.Play();
    }
    
    void Delay(){
        restartPanel.SetActive(true);
    }
    public void GoToGameScene(){
        SceneManager.LoadScene("Level 1");
        }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu(){
        SceneManager.LoadScene("Title");
    }

    public void GoToNextGameScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitApplication() {
        Application.Quit();
    
    }

    public void SkipButton() {
        SceneManager.LoadScene("Level's Scene");
    }


}



