using TMPro;
using UnityEngine;

public class Consultation2View : MonoBehaviour
{
    public TextMeshProUGUI text;

    private Consultation2Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation2Controller>();
        controller.DataCon2(Info.clanname, Info.benefit, ViewGet);
    }

    private void ViewGet(Consultation2DataModel[] dataModels)
    {
        foreach (Consultation2DataModel dataModel in dataModels)
        {
            text.text = "Members: " + dataModel.amount;
        }
    }
}
