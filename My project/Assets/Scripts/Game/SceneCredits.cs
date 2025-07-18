using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneCredits : MonoBehaviour
{

    [SerializeField] private Button scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scene.onClick.AddListener(Scene);
    }

    private void Scene()
    {
        SceneManager.LoadScene("Menu");
    }
}
