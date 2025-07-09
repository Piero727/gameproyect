using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button startButton;
    public Button rankingSumButton;
    public Button creditsButton;
    public Button userButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        rankingSumButton.onClick.AddListener(RankingSum); 
        creditsButton.onClick.AddListener(Credits);
        userButton.onClick.AddListener(UserStart);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    private void RankingSum()
    {
        SceneManager.LoadScene("Ranking Sum");
    }

    private void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    private void  UserStart()
    {
         SceneManager.LoadScene("User Start");
    }
}
