using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation6Controller : MonoBehaviour
{
    private string url = "http://localhost/consulpro3/consultation6.php"; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DataCon6(Action<Consultation6DataModel[]> callback)
    {
        StartCoroutine(SelectGet(callback));
    }

    private IEnumerator SelectGet(Action<Consultation6DataModel[]>callback)
    {
        using(UnityWebRequest www = UnityWebRequest.Get(url))
        {
            yield return www.SendWebRequest();
            if ((www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError))
            {
                Debug.Log("Mistake");
            }

            else if (www.downloadHandler.text == "Mistake")
            {
                Debug.Log("Mistake");
                
            }

            else
            {
                Consultation6Data datas = JsonUtility.FromJson<Consultation6Data>(www.downloadHandler.text);
                callback?.Invoke(datas.data);
            }
        }
    }
}
