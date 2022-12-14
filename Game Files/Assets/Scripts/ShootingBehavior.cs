using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public Transform shootpos;

    public GameObject projectile;

    private float TimeBtwShot;
    public float startTimeBtwShot;

    private void Update() {
        if (TimeBtwShot <= 0) {
            Instantiate(projectile, shootpos.position, Quaternion.identity);
            TimeBtwShot = startTimeBtwShot;
        } else {
            TimeBtwShot -= Time.deltaTime;
        }
    }
}
