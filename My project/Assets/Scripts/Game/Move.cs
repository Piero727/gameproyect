using UnityEngine;

public class Move : MonoBehaviour
{
    private Enemy enemy1;
    public int speedE;
    void Start()
    {
        enemy1 = new Enemy(speedE); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * enemy1.speed * Time.deltaTime);

        if (transform.position.x < -9.7f)
        {
            Destroy(gameObject);
        }
    }
}
