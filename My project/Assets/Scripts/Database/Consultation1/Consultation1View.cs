using UnityEngine;

public class Consultation1View : MonoBehaviour
{
    public string levelname;
    private Consultation1Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation1Controller>();
    }

    // Update is called once per frame
    public void Post1()
    {
        controller.Con1(Info.username, Info.score, levelname, Info.clanname, Info.benefit);
    }
}
