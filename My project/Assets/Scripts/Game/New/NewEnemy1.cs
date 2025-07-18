using UnityEngine;

public class NewEnemy1 : MonoBehaviour
{
    [SerializeField] private int life;
    private NewEnemy newEnemy;
    private GameObject player;
    [SerializeField] private float speed;

    private Rigidbody rb;

    private PlayerController2 playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newEnemy = new NewEnemy(life);
        rb = GetComponent<Rigidbody>();

        player = GameObject.Find("Player");

        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce((player.transform.position - transform.position).normalized * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            newEnemy.life -= 1;
            if (newEnemy.life <= 0)
            {
                Destroy(gameObject);
                playerController.score++;
                playerController.scoreText.text = "Score: " + playerController.score;
            }
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            playerController.life -= 1;
            playerController.lifeText.text = "Life: " + playerController.life;
            if (playerController.life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }


}
