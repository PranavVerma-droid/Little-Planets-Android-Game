using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsBehavior : MonoBehaviour
{
   public Transform otherPlanet;

   public float speed;
   public float secondsToMaxDifficulty;

    public float minSpeed;
    public float maxSpeed;

   private void Update() {
       speed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());
       transform.position = Vector2.MoveTowards(transform.position, otherPlanet.position, speed * Time.deltaTime);
   }
    float GetDifficultyPercent() {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }

}


