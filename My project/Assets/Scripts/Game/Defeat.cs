using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Defeat : MonoBehaviour
{
    public static string sceneName;

    [SerializeField] private Button sceneMenu;
    [SerializeField] private Button sceneReturn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        sceneMenu.onClick.AddListener(SceneMenu);
        sceneReturn.onClick.AddListener(SceneReturn);
    }



    private void SceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void SceneReturn()
    {
        SceneManager.LoadScene(sceneName);
    }
}
