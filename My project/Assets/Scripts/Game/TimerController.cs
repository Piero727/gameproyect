using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private float maxTimer = 40f;
    public float timer;
    public GameObject game;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = maxTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        game.GetComponent<Image>().fillAmount = timer / maxTimer;
    }
}
