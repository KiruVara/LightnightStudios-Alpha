using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHazard : MonoBehaviour
{
    public GameObject explosion;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Projectile"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (coll.collider.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
