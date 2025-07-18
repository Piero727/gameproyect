using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjectList = new List<GameObject>();

    [SerializeField] private float num1;
    [SerializeField] private float num2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        InvokeRepeating("SpawnerRandom", num1, num2);
    }


    private void SpawnerRandom()
    {
        Vector3 vectorPosion = new Vector3(10, 3.57f, -10);
        int randomIndex = Random.Range(0, gameObjectList.Count);
        Instantiate(gameObjectList[randomIndex], vectorPosion, transform.rotation);
    }
}
