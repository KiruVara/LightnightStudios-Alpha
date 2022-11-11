using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speedMaxX = 3.0f;
    public float speedMinX = -3.0f;
    public float speedMaxY = 3.0f;
    public float speedMinY = -3.0f;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(speedMinX, speedMaxX), Random.Range(speedMinY, speedMaxY)); 
    }

}
