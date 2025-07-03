using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Consultation4View : MonoBehaviour
{
    public TextMeshProUGUI textData;
    public Button likeButton;
    public TMP_InputField userLike;

    private string username;
    public string clanname;
    private Consultation4Controller controller;

    public Button sceneButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation4Controller>();
        likeButton.onClick.AddListener(Like);
        sceneButton.onClick.AddListener(SceneName);

    }

    private void Like()
    {

        textData.text = "";

        controller.Data4(userLike.text, Info.clanname,Info.benefit, Post4);
    }
    // Update is called once per frame
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
