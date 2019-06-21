using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;
    public List<GameObject> enemyList;
    // Start is called before the first frame update
    void Start()
    {
  
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag('Enemy'))
        {
            enemyList.Add(enemy);
        }


    }

    // Update is called once per frame
    void Update()
    {
     



    }

    public void DamageEnemies()
    {
        foreach (GameObject enemy in enemyList)
        {
            enemy.GetComponent<Stats>().health -= 10;
        }
    }

    public void HealEnemies()
    {
        foreach (GameObject enemy in enemyList)
        {
            enemy.GetComponent<Stats>().health += 10;
        }
    }

    public void RemoveEnemy(GameObject enemyToRemove)
    {
        enemyList.Remove(enemyToRemove);
    }

}
