using UnityEngine;

public class Detector : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
        Debug.Log($"Touched: {c.gameObject.name}");
        // this tells that object is finished
    }
}