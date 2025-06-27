using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation2Controller : MonoBehaviour
{
    
    private string url= "http://localhost/consulpro3/consultation2.php"; 
    public void DataCon2(string clanname, string benefit, Action<Consultation2DataModel[]> callback)
    {
        StartCoroutine(SeletcGet(clanname, benefit, callback));
    }

    private IEnumerator SeletcGet(string clanname, string benefit, Action<Consultation2DataModel[]> callback)
    {
        WWWForm form = new WWWForm();
        form.AddField("clanname", clanname);
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
                Consultation2Data datas = JsonUtility.FromJson<Consultation2Data>(www.downloadHandler.text);
                callback?.Invoke(datas.data);
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
