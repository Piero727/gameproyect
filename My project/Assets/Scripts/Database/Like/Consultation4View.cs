using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Consultation4View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textData;
    [SerializeField] private Button likeButton;
    [SerializeField] private TMP_InputField userLike;

    private Consultation4Controller controller;

    [SerializeField] private Button sceneButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation4Controller>();
        likeButton.onClick.AddListener(Like);
        sceneButton.onClick.AddListener(SceneName);

    }

    private void Like()
    {

        string trimmedInput = userLike.text.Trim();
        if (string.IsNullOrEmpty(trimmedInput))
        {
            Debug.Log("No results");
        }
        else
        {
            textData.text = "";

            controller.Data4(userLike.text, Info.clanname, Info.benefit, Post4);
        }


        
    }

    private void Post4(Consultation4DataModel[] dataModels)
    {
        foreach (Consultation4DataModel dataModel in dataModels)
        {
            textData.text += dataModel.username + "\n";
        }
    }

    private void SceneName()
    {
        SceneManager.LoadScene("Menu");
    }

}
