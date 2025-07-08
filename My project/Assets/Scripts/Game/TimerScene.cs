using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScene : MonoBehaviour
{
    private int timeScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeScene = 1000;

    }

    // Update is called once per frame
    void Update()
    {

        timeScene--;
        if (timeScene <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

    }
}
