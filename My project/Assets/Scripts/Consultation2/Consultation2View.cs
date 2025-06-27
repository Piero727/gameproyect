using TMPro;
using UnityEngine;

public class Consultation2View : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string clanname;
    public string benefit;
    private Consultation2Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation2Controller>();
        controller.DataCon2(clanname, benefit, ViewGet);
    }

    private void ViewGet(Consultation2DataModel[] dataModels)
    {
        foreach (Consultation2DataModel dataModel in dataModels)
        {
            text.text += dataModel.amount;
        }
    }
}
