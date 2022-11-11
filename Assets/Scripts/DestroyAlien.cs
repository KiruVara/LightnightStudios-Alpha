using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAlien : MonoBehaviour 
{
    public KillScore killScore;

    public GameObject explosion;

    void Start()
    {
        killScore = GameObject.FindGameObjectWithTag("Player").GetComponent<KillScore>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Projectile"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            killScore.Kill();
        }
        if (coll.collider.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
    
}
