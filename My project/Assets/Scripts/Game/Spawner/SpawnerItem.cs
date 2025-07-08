using UnityEngine;

public class SpawnerItem : MonoBehaviour
{
    public GameObject itemPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1 = Random.Range(7,10);
        int number2 = Random.Range(12, 18);

        InvokeRepeating("Spawner", number1, number2);
    }

    // Update is called once per frame
    private void Spawner()
    {
        Vector3 vectorPosion = new Vector3(10.87f, 5.3f, -10);
        Instantiate(itemPrefab, vectorPosion, transform.rotation);
    }
}
