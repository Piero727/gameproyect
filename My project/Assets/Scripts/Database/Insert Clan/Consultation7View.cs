using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Consultation7View : MonoBehaviour
{
    [SerializeField] private Button buttonCon7;
    [SerializeField] private TMP_InputField clanInput;
    [SerializeField] private TMP_Dropdown benefitDropdown;
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
        string trimmedInput = clanInput.text.Trim();

        if (string.IsNullOrEmpty(trimmedInput))
        {
            Debug.Log("Miskete");
        }

        else
        {
            Info.benefit = benefitDropdown.options[benefitDropdown.value].text;
            if (Info.benefit == "life")
            {
                Info.life = 3;
                Info.clanname = clanInput.text;
                controller.Con7(Info.clanname, Info.benefit);
                SceneManager.LoadScene("Menu");
            }
            else if (Info.benefit == "extrascore")
            {
                Info.extrascore = 10;
                Info.clanname = trimmedInput;
                controller.Con7(Info.clanname, Info.benefit);
                SceneManager.LoadScene("Menu");
            }
        }


        

    }


    private void User()
    {
        string trimmedInput = clanInput.text.Trim();
        if (string.IsNullOrEmpty(trimmedInput))
        {
            Debug.Log("Miskete");
        }
        else
        {
            Info.username = trimmedInput;
            SceneManager.LoadScene("Clan Start");
        }
    }
}
