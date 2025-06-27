using TMPro;
using UnityEngine;

public class Consultation3View : MonoBehaviour
{
    public TextMeshProUGUI text;
    private Consultation3Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation3Controller>();
        controller.DataCon3(ViewGet);

    }

    private void ViewGet(Consultation3DataModel[] dataModels)
    {
        foreach (Consultation3DataModel dataModel in dataModels)
        {
            text.text += dataModel.username+ "          " + dataModel.clanname+ "          " + dataModel.score_total + "\n";
        }
    }
}
