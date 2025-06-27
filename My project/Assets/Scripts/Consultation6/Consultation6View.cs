using TMPro;
using UnityEngine;

public class Consultation6View : MonoBehaviour
{
    public TextMeshProUGUI text;
    private Consultation6Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation6Controller>();
        controller.DataCon6(Get6);
    }

    private void Get6(Consultation6DataModel[] consultation6DataModels)
    {
        foreach (Consultation6DataModel dataModel in consultation6DataModels)
        {
            text.text += dataModel.clanname + "      " + dataModel.benefit + "      " + dataModel.average_score + "      " + dataModel.amount + "\n"; ; 
        }
    }
}
