using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation9Controller : MonoBehaviour
{
    private string url = "http://localhost/consulpro3/consultation9.php";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DataCon9(Action<Consultation9DataModel[]> callback)
    {
        StartCoroutine(Post(callback));
    }

    private IEnumerator Post(Action<Consultation9DataModel[]> callback)
    {
        using(UnityWebRequest www = UnityWebRequest.Get(url))
        {
            yield return www.SendWebRequest();
            if(www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Mistake");
            }
            else if(www.downloadHandler.text == "Mistake")
            {
                Debug.Log("Mistake");
            }

            else
            {
                Consultation9Data consultation = JsonUtility.FromJson<Consultation9Data>(www.downloadHandler.text);
                callback?.Invoke(consultation.data);
            }
        }
    }
}
