using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation1Controller : MonoBehaviour
{
    private string url = "http://localhost/consulpro3/consultation1.php"; 

    public void Con1(string username, int score, string levelname, string clanname, string benefit)
    {
        StartCoroutine(PostData(username, score,levelname,clanname,benefit));
    }

    private IEnumerator PostData(string username, int score, string levelname, string clanname, string benefit)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("score", score);
        form.AddField("levelname", levelname);
        form.AddField("clanname", clanname);
        form.AddField("benefit", benefit);
        using(UnityWebRequest www = UnityWebRequest.Post(url,form))
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
