using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float cooldownDuration = 3.0f;
    private float currentCooldown = 0f;
    public bool leftCheck = false;
    public float speed = 3f;

    public GameObject MyCylinder;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        currentCooldown += Time.deltaTime;
        for (int i = 0; i <= 5; i++)
        {
            if (currentCooldown >= 3.0f)
            {

                Spawn();
                currentCooldown = 0f;
            }
        }
    }

    void Move()
    {
        if (transform.position.x <= 4.36 && leftCheck == false)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (transform.position.x >= 4.36 && leftCheck == false)
        {
            leftCheck = true;
        }

        if (leftCheck == true)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (leftCheck == true && transform.position.x <= -4.94)
        {
            leftCheck = false;
        }

    }

    void Spawn()
    {
        Instantiate(MyCylinder);
    }
}
