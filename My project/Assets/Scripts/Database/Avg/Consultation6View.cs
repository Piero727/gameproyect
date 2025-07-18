using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Consultation6View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Button clanButton;
    [SerializeField] private Button level3Button;

    private Consultation6Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation6Controller>();
        controller.DataCon6(Get6);
        clanButton.onClick.AddListener(SceneClan);
        level3Button.onClick.AddListener(SceneLevel3);

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

    private void SceneLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
