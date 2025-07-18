using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation7Controller : MonoBehaviour
{
    private string url = "http://localhost/consulpro3/insertclan.php";

    public void Con7(string clanname, string benefit)
    {
        StartCoroutine(PosData(clanname, benefit));
    }

    private IEnumerator PosData(string clanname, string benefit)
    {
        WWWForm form = new WWWForm();
        form.AddField("clanname", clanname);
        form.AddField("benefit", benefit);
        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
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
