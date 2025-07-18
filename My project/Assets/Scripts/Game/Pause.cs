using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button menuButton;

    [SerializeField] private GameObject pauseGameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseButton.onClick.AddListener(PauseScene);
        resumeButton.onClick.AddListener(ResumeScene);
        menuButton.onClick.AddListener(MenuScene);
    }

    private void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    private void ResumeScene()
    {
        Time.timeScale = 1;

        pauseGameObject.SetActive(false);
        Debug.Log("Game Resumed");
    }
    private void PauseScene()
    {
        Time.timeScale = 0; 

        pauseGameObject.SetActive(true);
        Debug.Log("Game Paused");


    }
}
