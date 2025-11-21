using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private PlayerData playerdata;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerdata = GetComponent<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        if (rb != null) {
            Vector3 vel = rb.linearVelocity;
            vel.z = playerdata.forwardSpeed;

            rb.linearVelocity = vel;

            Vector3 pos = rb.position;
            rb.position = pos;
        }
    }
}
