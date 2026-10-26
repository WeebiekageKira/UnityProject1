using UnityEngine;

public class BallSlammer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 initialVelocity = new Vector3(0f, 0f, 0f);

    private Rigidbody rb; //specific over dit object

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = initialVelocity;
    }

    void Update()
    {
     
    }
}
