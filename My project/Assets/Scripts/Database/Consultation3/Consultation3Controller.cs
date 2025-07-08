using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Consultation3Controller : MonoBehaviour
{
    private string url = "http://localhost/consulpro3/consultation3.php";  

    public void DataCon3(Action<Consultation3DataModel[]> callback)
    {
        StartCoroutine(Get(callback));
    }

    private IEnumerator Get(Action<Consultation3DataModel[]> callback)
    {
        using(UnityWebRequest www = UnityWebRequest.Get(url))
        {
            yield return www.SendWebRequest();
            if(www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log("Mistake");
            }

            else if (www.downloadHandler.text == "Mistake")
            {
                Debug.Log("Mistake");
                
            }

            else
            {
                Consultation3Data datas = JsonUtility.FromJson<Consultation3Data>(www.downloadHandler.text);
                callback?.Invoke(datas.data);

            }
        }
    }
}
