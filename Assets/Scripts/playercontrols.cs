using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontrols : MonoBehaviour
{
    private Rigidbody2D rg2d;
    float thrust = 2f;
    float rotationSpeed = 180f;
    float maxSpeed = 4f;

    public Text LivesText;
    public int lives = 3;

    public Text GameOver;
    public string Loss;

    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ControlPlayer();

        if (rg2d.velocity.magnitude > maxSpeed)
        {
            rg2d.velocity = rg2d.velocity.normalized * maxSpeed;
        }
    }

    private void ControlPlayer()
    {
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        GetComponent<Rigidbody2D>().AddForce(transform.up * thrust * Input.GetAxis("Vertical"));
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Hazard"))
        {
          //  Destroy(this.gameObject);
            ResetPlayer();
            Die();
        }
        if (coll.collider.CompareTag("Alien"))
        {
            ResetPlayer();
            Die();
        }
    }

    void ResetPlayer()
    {
        rg2d.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
        rg2d.angularVelocity = Random.Range(0, 0);
    }

    void Die()
    {
        lives--;
        SubLives();

        if(lives <= 0)
        {
            Lose();
        }
    }

    void SubLives()
    {
        LivesText.text = "Lives: " + lives.ToString();
    }

    void Lose()
    {
        Stop();
        GameOver.text = Loss;
    }

    void Stop()
    {
       // rg2d.velocity = new Vector2(0, 0);
        transform.position = new Vector2(99, 0);
        Destroy(this.gameObject);
    }
}
