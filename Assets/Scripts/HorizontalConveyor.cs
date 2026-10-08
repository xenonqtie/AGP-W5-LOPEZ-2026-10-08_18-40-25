using UnityEngine;

public class HorizontalConveyor : MonoBehaviour
{
    [SerializeField] float beltSpeed = 3f;

    void OnCollisionStay(Collision c)
    {
        Rigidbody rb = c.rigidbody;
        if (rb == null) return;

        float currentX = rb.linearVelocity.x; 
        float missing = beltSpeed - currentX;
        rb.AddForce(Vector3.right * missing, ForceMode.VelocityChange);
    }
}