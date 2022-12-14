using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private GameObject[] planets;

    private Vector2 target;

    public float speed;

    private GameMaster gm;

    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        planets = GameObject.FindGameObjectsWithTag("Planets");

        int rand = Random.Range(0, planets.Length);
        target = planets[rand].transform.position;
    }

    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) < 0.2f) {
            Destroy(gameObject);
        
        }
    }

    private void OnTriggerEnder2D(Collider2D other){
        if (other.CompareTag("Planet")) {
            gm.GameOver();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
