using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int speedForce;
    private Rigidbody rb;
    public bool isGrounded = false;

    private int life = 3 + Info.life;
    public TextMeshProUGUI lifeText;
    
    private int score = 0 + +Info.extrascore;
    public TextMeshProUGUI scoreText;

    public Button finish;

    public string sceneName;

    private Consultation1View consultation1View;
    private Consultation5View consultation5View;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        consultation1View = GetComponent<Consultation1View>();
        consultation5View = GetComponent<Consultation5View>();
        rb = GetComponent<Rigidbody>();
        lifeText.text = "Life: " + life ;
        scoreText.text = "Score: " + score ;
        finish.onClick.AddListener(SceneFinish);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * speedForce, ForceMode.Impulse);

            isGrounded = false;
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
                Info.score = score;
                consultation1View.Post1();
                SceneManager.LoadScene(sceneName);
            }

        }

        if (collision.gameObject.CompareTag("EnemyPlus"))
        {
            life--;
            lifeText.text = "Life: " + life;
            Destroy(collision.gameObject);
            if (life <= 0)
            {
                consultation5View.Post5();
                SceneManager.LoadScene("Clan Start");

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

        if (other.CompareTag("ScorePlus"))
        {
            score+= 10;

            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);

            if (score >= 50)
            {
                finish.transform.position = new Vector3(922, 944, 0);
            }
        }

        if (other.CompareTag("End"))
        {
            consultation5View.Post5();
            SceneManager.LoadScene("Clan Start");
        }
    }

    private void SceneFinish()
    {
        Info.score = score;
        consultation1View.Post1();
        SceneManager.LoadScene("Clan");
    }
}

