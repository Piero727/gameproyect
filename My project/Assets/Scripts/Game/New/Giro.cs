using UnityEngine;

public class Giro : MonoBehaviour
{
    [SerializeField] private float giroSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * horizontal * giroSpeed * Time.deltaTime);
    }
}
