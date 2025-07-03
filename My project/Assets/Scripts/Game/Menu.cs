using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button startButton;
    public Button rankingSumButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        rankingSumButton.onClick.AddListener(RankingSum); 
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    private void RankingSum()
    {
        SceneManager.LoadScene("Ranking Sum");
    }
}
