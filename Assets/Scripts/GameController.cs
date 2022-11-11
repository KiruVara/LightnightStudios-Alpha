using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public GameObject hazard2; 
    public Vector2 spawnValue;
    public int hazardCount;

    public float startWait;
    public float spawnWait, hazard2Wait;
    public float waveWait; 

    private Vector2 spawnPosition; 
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait); 

        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                int choice = Random.Range(0, 4);
                

                switch (choice)
                {
                    case 0:
                        spawnPosition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));
                        Instantiate(hazard2, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(hazard2Wait);
                        break;
                    case 1:
                        spawnPosition = new Vector2(-spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));
                        Instantiate(hazard, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 2:
                        spawnPosition = new Vector2(Random.Range(-spawnValue.x, spawnValue.x), -spawnValue.y);
                        Instantiate(hazard, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 3:
                        spawnPosition = new Vector2(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y);
                        Instantiate(hazard, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 4:
                        spawnPosition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));
                        Instantiate(hazard, spawnPosition, Quaternion.identity);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                }

            }
            yield return new WaitForSeconds(waveWait); 
        }

    }
}
