using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Consultation5View : MonoBehaviour
{
    private Consultation5Controller controller;
    public Button buttonDelete;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<Consultation5Controller>();
        buttonDelete.onClick.AddListener(Post5);
    }


    private void Post5()
    {
        controller.Data5(Info.clanname, Info.username, Info.benefit);
        SceneManager.LoadScene("User Start");
    }
}
