using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> gameObjectList = new List<GameObject>();

    private float num1 = 1f;
    public float num2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnerRandom", num1, num2);
    }


    private void SpawnerRandom()
    {
        Vector3 vectorPosion = new Vector3(0, -1.08f, 0);
        int randomIndex = Random.Range(0, gameObjectList.Count);
        Instantiate(gameObjectList[randomIndex], transform.position + vectorPosion, transform.rotation);
    }
}
