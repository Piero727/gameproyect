using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speedForce1;
    [SerializeField] private int speedForce2;
    private Rigidbody rb;
    [SerializeField] private bool isGrounded = false;

    private int life = 3 + Info.life;
    [SerializeField] private TextMeshProUGUI lifeText;
    
    private int score = 0 + Info.extrascore;
    [SerializeField] private TextMeshProUGUI scoreText;


    [SerializeField] private string returnScene;
    [SerializeField] private string sceneName;
    private int reward;

    private Consultation1View consultation1View;

    private TimerController timerController;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        consultation1View = GetComponent<Consultation1View>();
        timerController = GetComponent<TimerController>();
        rb = GetComponent<Rigidbody>();

        lifeText.text = "Life: " + life ;
        scoreText.text = "Score: " + score ;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * speedForce1, ForceMode.Impulse);

            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.D) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * speedForce2, ForceMode.Impulse);

            isGrounded = false;
        }

        if (timerController.timer <= 0)
        {
            Info.score = score;
            consultation1View.Post1();
            SceneManager.LoadScene(sceneName);
        }

    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }


        if (collision.gameObject.CompareTag("Enemy"))
        {
            life--;
            lifeText.text = "Life: " + life;
            Destroy(collision.gameObject);
            if (life <= 0)
            {
                Defeat.sceneName = returnScene;
                SceneManager.LoadScene("Defeat");

            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Score"))
        {
            score++;
            
            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);
            
        }

        if (other.CompareTag("ScoreHigh"))
        {
            score += 3;

            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);

        }


        if (other.CompareTag("Timer"))
        {
            reward++;
            Destroy(other.gameObject);

            if (reward == 1)
            {
                reward = 0;
                timerController.timer += 10;
            }
        }
    }
}