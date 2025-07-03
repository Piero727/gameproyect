using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation5Controller : MonoBehaviour
{
    private string url = "http://localhost/consulpro3/consultation5.php";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Data5(string clannname, string username, string benefit)
    {
        StartCoroutine(SelectPost(clannname, username,benefit));
    }

    private IEnumerator SelectPost( string clannname, string username, string benefit)
    {
        WWWForm form = new WWWForm();
        form.AddField("clanname", clannname);
        form.AddField("username", username);
        form.AddField("benefit", benefit);

        using (UnityWebRequest www = UnityWebRequest.Post(url,form))
        {
            yield return www.SendWebRequest();
            if(www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Mistake");
            }

            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
