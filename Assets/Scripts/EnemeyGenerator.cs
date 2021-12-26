using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyGenerator : MonoBehaviour
{
    public GameObject enemey;

    public float secondsBetweenSpawn;
    public float elapsedTime = 0.0f;
 
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
         elapsedTime += Time.deltaTime;
 
         if (elapsedTime > secondsBetweenSpawn)
         {
            elapsedTime = 0;
            Debug.Log(true);   
        
            Vector3 spawnPosition = new Vector3 (4.71f, 0.72f, 0f);
            GameObject newEnemy = (GameObject)Instantiate(enemey, spawnPosition, Quaternion.Euler (0, 0, 0));
         }
        
    }
}
