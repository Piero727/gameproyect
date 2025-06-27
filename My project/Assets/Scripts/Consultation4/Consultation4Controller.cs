using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation4Controller : MonoBehaviour
{
    private string url= "http://localhost/consulpro3/consultation4.php"; 

    public void Data4(string username, string clanname, Action<Consultation4DataModel[]> callback)
    {
        StartCoroutine(SelectPost(username, clanname, callback));
    }


    private IEnumerator SelectPost(string username, string clanname, Action<Consultation4DataModel[]> callback)
    {
        WWWForm form = new WWWForm();
        form.AddField("username",username );
        form.AddField("clanname", username);
        using (UnityWebRequest www = UnityWebRequest.Post(url,form))
        {
            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Mistake");
            }
            else
            {
                Consultation4Data datas = JsonUtility.FromJson<Consultation4Data>(www.downloadHandler.text);
                callback?.Invoke(datas.data);
            }
        }
    }
}
