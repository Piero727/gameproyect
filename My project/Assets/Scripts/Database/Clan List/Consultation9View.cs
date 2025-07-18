using UnityEngine;
using TMPro;

public class Consultation9View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private Consultation9Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation9Controller>();
        controller.DataCon9(Get);
    }

    private void Get(Consultation9DataModel[] dataModels)
    {
        foreach (Consultation9DataModel dataModel in dataModels)
        {
            text.text += dataModel.clanname + "               " + dataModel.benefit + "\n";
        }
    }
}
