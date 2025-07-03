using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarU : MonoBehaviour
{
    public Button buttonU;

    public TMP_InputField userInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonU.onClick.AddListener(User);
        Debug.Log(Info.life);
        Debug.Log(Info.extrascore);
    }

    private void User()
    {
        Info.username = userInput.text;
        SceneManager.LoadScene("Menu");
    }
}
