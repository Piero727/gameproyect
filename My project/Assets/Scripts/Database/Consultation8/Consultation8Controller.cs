using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation8Controller : MonoBehaviour
{
    private string url = "http://localhost/consulpro3/consultation8.php";
    
    public void Consultation8(Action<Consultation8DataModel[]> callback)
    {
        StartCoroutine(ConsulData8(callback));
    }

    private IEnumerator ConsulData8(Action<Consultation8DataModel[]> callback)
    {
        using(UnityWebRequest www = UnityWebRequest.Get(url))
        {
            yield return www.SendWebRequest();
            if(www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Mistake");
            }

            else
            {
                Consultation8Data consultation = JsonUtility.FromJson<Consultation8Data>(www.downloadHandler.text);
                callback?.Invoke(consultation.data);
            }
        }
    }
}
