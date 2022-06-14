using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{


   public Transform[] SpawnPoints;
    public GameObject fruit;


    float min=0.2f, max=2f;



    private void Start()
    {
        StartCoroutine(SpawnFruits());
    }
    IEnumerator SpawnFruits()
    {

        while (true)
        {
            float delay = Random.Range(min, max);
            yield return new WaitForSeconds(2);






        }


    }
}
