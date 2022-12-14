using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{
    
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetposition;

    public float minSpeed;
    public float maxSpeed;

    float speed;
    
    public float secondsToMaxDifficulty;

    
    
    // Start is called before the first frame update
    void Start()
    {
        targetposition = GetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetposition) 
        {
            speed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());
            transform.position = Vector2.MoveTowards(transform.position, targetposition, speed * Time.deltaTime);
        } else {
            targetposition = GetRandomPosition();
        }
    }

    Vector2 GetRandomPosition() {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }


   

    float GetDifficultyPercent() {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    
    }
}
