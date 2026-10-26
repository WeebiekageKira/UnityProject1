using UnityEngine;
using UnityEngine.UIElements;

public class PerfectRotation : MonoBehaviour
{
    public float rotateSpeed = 90f;
    public bool leftCheck = false;
    public float speed = 3f;

    public float startLocation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startLocation = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0); //0 is x and z as

        //if (transform.position.x <= startLocation + 5 && leftCheck == false)
        //{
        //    transform.position += Vector3.right * speed * Time.deltaTime;
        //}

        //if (transform.position.x >= startLocation + 5 && leftCheck == false)
        //{
        //    leftCheck = true;
        //}

        //if (leftCheck == true)
        //{
        //    transform.position += Vector3.left * speed * Time.deltaTime;
        //}

        //if (leftCheck == true && transform.position.x <= startLocation - 5)
        //{
        //    leftCheck = false;
        //}
    }
}
