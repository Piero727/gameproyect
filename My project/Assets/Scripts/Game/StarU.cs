using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarU : MonoBehaviour
{
    [SerializeField] private Button buttonU;

    [SerializeField] private TMP_InputField userInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonU.onClick.AddListener(User);
    }

    private void User()
    {
        string trimmedInput = userInput.text.Trim();
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
