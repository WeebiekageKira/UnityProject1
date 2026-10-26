using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    private Rigidbody rb;
    float speed = 3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //gebruik van input systeem van unity op basis van horizontale en verticale as
        float vertical = Input.GetAxis("Vertical");
     
        Vector3 direction = new Vector3(horizontal, 0f, vertical); //X Y Z as

        rb.linearVelocity = new Vector3(direction.x * speed, rb.linearVelocity.y, direction.z * speed);

        //Vector3 move = new Vector3(1, 0, 0) * speed * Input.GetAxis("Horizontal") * Time.deltaTime;
    }
}
