using UnityEngine;

public class SpawnerFloor : MonoBehaviour
{
    public GameObject prefabFloor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawner", 3.3f, 5.0f);
    }

    // Update is called once per frame
    private void Spawner()
    {
        Vector3 spawnerPosition = new Vector3(-0.3519f, 0.8512f, -10);
        Instantiate(prefabFloor, transform.position, transform.rotation);
    }
}
