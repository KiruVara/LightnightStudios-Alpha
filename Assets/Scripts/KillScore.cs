using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillScore : MonoBehaviour
{
    public Text EnemyText;
    public int enemies;

    public string nextLevel;

    public void Kill()
    {
        enemies--;
        SubEnemies();
        
        if(enemies == 0)
        {
            LoadScene();
        }
    }

    public void SubEnemies()
    {
        EnemyText.text = "Enemies Remaining: " + enemies.ToString();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(nextLevel);
    }
}