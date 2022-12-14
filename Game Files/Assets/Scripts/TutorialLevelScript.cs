using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialLevelScript : MonoBehaviour
{
    
    public void NextTutorialLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
