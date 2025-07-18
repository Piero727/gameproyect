using TMPro;
using UnityEngine;

public class Consultation8View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private Consultation8Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation8Controller>();
        controller.Consultation8(Post8);
    }

    private void Post8(Consultation8DataModel[] dataModels)
    {
        foreach (Consultation8DataModel dataModel in dataModels)
        {
            text.text += dataModel.amount + "\n";
        }
    }
}
