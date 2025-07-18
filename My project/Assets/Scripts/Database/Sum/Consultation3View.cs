using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Consultation3View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private Consultation3Controller controller;
    [SerializeField] private Button scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation3Controller>();
        controller.DataCon3(ViewGet);
        scene.onClick.AddListener(SceneName);

    }

    private void ViewGet(Consultation3DataModel[] dataModels)
    {
        foreach (Consultation3DataModel dataModel in dataModels)
        {
            text.text += dataModel.username+ "                    " + dataModel.clanname+ "                    " + dataModel.score_total + "\n";
        }
    }

    private void SceneName()
    {
        SceneManager.LoadScene("Menu");
    }
}
