using UnityEngine;

public class RespawnOnFall : MonoBehaviour
{
    public Transform spawnPoint;   // <-- Transform, not Vector3
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -5f)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = spawnPoint.position;
    }
}