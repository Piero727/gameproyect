using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Consultation7View : MonoBehaviour
{
    public Button buttonCon7;
    public TMP_InputField clanInput;
    public TMP_Dropdown benefitDropdown;
    private Consultation7Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation7Controller>();
        buttonCon7.onClick.AddListener(Post7);
        Info.life = 0;
        Info.extrascore = 0;
    }

    private void Post7()
    {
        Info.benefit = benefitDropdown.options[benefitDropdown.value].text;
        if(Info.benefit == "life")
        {
            Info.life = 3;
            Info.clanname = clanInput.text;
            controller.Con7(Info.clanname, Info.benefit);
            SceneManager.LoadScene("User Start");
        }
        else if (Info.benefit == "extrascore")
        {
            Info.extrascore = 10;
            Info.clanname = clanInput.text;
            controller.Con7(Info.clanname, Info.benefit);
            SceneManager.LoadScene("User Start");
        }

    }

}
