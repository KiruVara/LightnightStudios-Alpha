using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform triggerPoint;

    public float force = 5 - .0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject laser = Instantiate(laserPrefab, triggerPoint.position, triggerPoint.rotation);
            Rigidbody2D rBody = laser.GetComponent<Rigidbody2D>();
            rBody.AddForce(triggerPoint.up * force, ForceMode2D.Impulse); 
        }
    }
}
