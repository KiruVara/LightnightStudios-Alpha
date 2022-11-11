using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenWrap : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x > 11)
        {
            transform.position = new Vector3(-11, transform.position.y, 0);
        }
        
        else if(transform.position.x < -11)
        {
            transform.position = new Vector3(11, transform.position.y, 0);
        }
        else if ( transform.position.y > 6)
        {
            transform.position = new Vector3 (transform.position.x, -6, 0);
        }
        else if (transform.position.y < -6)
        {
            transform.position = new Vector3(transform.position.x, 6, 0);
        }
    }
}
