using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public int collected = 0;
    public int stamina = 1;

    public float currentHealth = 100;
    private float force = 250f;

    private float goonbaForce = 1000f;
    private Rigidbody rb; //rb = rigidbody
    public Vector2 turn;

    public bool hasKey = false;

    public bool level2 = false;
    public bool level3 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //pak de rigidbody van dit object
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //gebruik van input systeem van unity op basis van horizontale en verticale as
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical); //X Y Z as
        rb.linearVelocity = new Vector3(direction.x * speed, rb.linearVelocity.y, direction.z * speed);

        //Vector3 move = new Vector3(1, 0, 0) * speed * Input.GetAxis("Horizontal") * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && stamina > 0)
        {
            jump();
        }
        LevelManager();

        if (Input.GetKeyDown(KeyCode.V))
        {
            collected += 1;
        }

        //Debug.Log($"Current Health: {currentHealth}");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("goomba"))
        {
            currentHealth -= 10;
            rb.AddForce(Vector3.back * goonbaForce);

            if (currentHealth >= 80)
            {
                Debug.Log("Good health.");
            }
            else if (currentHealth >= 50 && currentHealth < 80)
            {
                Debug.Log("Medium health");
            }
            else if (currentHealth <= 20)
            {
                Debug.Log("Critical health");
            }
        }

        if (other.CompareTag("collectible"))
        {
            collected += 1;
            Debug.Log($"Coins collected {collected}");
        }

        if (other.CompareTag("key"))
        {
            hasKey = true;
            Debug.Log("Key tastes better than bread");
        }
        

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("killzone"))
        {
            Destroy(gameObject);
        }

        
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("floor") && stamina < 1)
        {
            Debug.Log(stamina);
            stamina++;
        }
        if (other.gameObject.CompareTag("rock") && stamina < 1)
        {
            Debug.Log(stamina);
            stamina++;
        }

        if (other.gameObject.tag == "door" && hasKey == true)
        {
            Destroy(other.gameObject);
        }

    

    }
    void jump()
    {
        rb.AddForce(Vector3.up * force);
        stamina--;
    }

    public void LevelManager()
    {
        
        if (collected == 2 && level2 == false)
        {
            gameObject.transform.position = new Vector3(22, 3.3f, -22);
            level2 = true;
        }
        if (collected == 6 && level3 == false)
        {
            gameObject.transform.position = new Vector3(44.45f, 1.96f, -8.46f);
            level3 = true;
        }

    }
}
