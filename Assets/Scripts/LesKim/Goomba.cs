using UnityEngine;
using UnityEngine.UIElements;

public class Goomba : MonoBehaviour
{
    public bool leftCheck = false;
    public float speed = 3f;

    private float xPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xPosition = transform.position.x;
    }

    // Update is called once per fram
    void Update()
    {
        
        if (transform.position.x <= xPosition + 5 && leftCheck == false)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (transform.position.x >= xPosition + 5 && leftCheck == false)
        {
            leftCheck = true;
        }

        if (leftCheck == true)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (leftCheck == true && transform.position.x <= xPosition - 5)
        {
            leftCheck = false;
        }
    }
}
