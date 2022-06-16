using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{


   public Transform[] SpawnPoints;
    public GameObject fruit;


    float min=0.1f, max=0.5f;



    private void Start()
    {
        StartCoroutine(SpawnFruits());
    }
    IEnumerator SpawnFruits()
    {

        while (true)
        {
            float delay = Random.Range(min, max);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, SpawnPoints.Length);
            Transform spawnPoint= SpawnPoints[spawnIndex];
            GameObject spawn = Instantiate(fruit, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawn, 5f);



        }


    }
}
