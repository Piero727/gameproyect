using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Consultation6View : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button clanButton;

    private Consultation6Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation6Controller>();
        controller.DataCon6(Get6);
        clanButton.onClick.AddListener(SceneClan);

    }

    private void Get6(Consultation6DataModel[] consultation6DataModels)
    {
        foreach (Consultation6DataModel dataModel in consultation6DataModels)
        {
            text.text += dataModel.clanname + "              " + dataModel.benefit + "              " + dataModel.average_score +  "\n";
        }
    }

    private void SceneClan()
    {
        SceneManager.LoadScene("Clan");
    }
}
