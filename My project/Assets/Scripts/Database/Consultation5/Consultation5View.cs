using UnityEngine;

public class Consultation5View : MonoBehaviour
{
    private Consultation5Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation5Controller>();
    }


    public void Post5()
    {
        controller.Data5(Info.clanname, Info.username, Info.benefit);
    }
}
