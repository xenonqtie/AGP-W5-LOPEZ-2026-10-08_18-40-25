using UnityEngine;

public class DiagonalConveyor : MonoBehaviour
{
    [SerializeField] float beltSpeed = 4f;
    [SerializeField] Vector3 direction = new Vector3(1f, 0f, 1f);

    void OnCollisionStay(Collision c)
    {
        Rigidbody rb = c.rigidbody;
        if (rb == null) return;

        Vector3 targetVelocity = direction.normalized * beltSpeed;
        Vector3 missing = targetVelocity - rb.linearVelocity;

        rb.AddForce(missing, ForceMode.VelocityChange);
    }
}