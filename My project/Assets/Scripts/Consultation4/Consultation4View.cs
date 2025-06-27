using TMPro;
using UnityEngine;

public class Consultation4View : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string username;
    public string clanname;
    private Consultation4Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation4Controller>();
        controller.Data4(username, clanname, Post4);
    }

    // Update is called once per frame
    private void Post4(Consultation4DataModel[] dataModels)
    {
        foreach (Consultation4DataModel dataModel in dataModels)
        {
            text.text += dataModel.userName;
        }
    }
}
