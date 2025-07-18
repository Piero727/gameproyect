using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button rankingSumButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button userButton;
    [SerializeField] private Button gooutButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        rankingSumButton.onClick.AddListener(RankingSum); 
        creditsButton.onClick.AddListener(Credits);
        userButton.onClick.AddListener(UserStart);
        gooutButton.onClick.AddListener(GoOut);
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

    private void GoOut()
    {
        
        Application.Quit();
        
    }
}
