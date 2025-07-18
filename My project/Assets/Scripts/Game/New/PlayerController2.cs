using TMPro;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float giroSpeed;
    [SerializeField] private GameObject prefab;
    public int life;
    public int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        life = 3;
        score = 0;

        scoreText.text = "Score: " + score;
        lifeText.text = "Life: " + life;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontal * giroSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
        
    }
}
