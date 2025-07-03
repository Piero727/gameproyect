using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private  float speed = 5.0f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -30.7f)
        {
            Destroy(gameObject);
        }
    }
}
