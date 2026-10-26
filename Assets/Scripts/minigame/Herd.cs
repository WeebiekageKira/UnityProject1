using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Herd : MonoBehaviour
{
    //public float cooldownDuration = 3.0f;
    //private float currentCooldown = 0f;
    private Rigidbody rb;
    private int counter;

    public GameObject MyCylinder;

    private float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //currentCooldown += Time.deltaTime;
        //for (int i = 0; i <= 5; i++)
        //{
        //    if (currentCooldown >= 3.0f)
        //    {
                
        //        Spawn();
        //        currentCooldown = 0f;
        //    }
        //}


        //Vector3 direction = GetComponent<Vector3>();
        if (transform.position.z >= -14.50)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        } //als er 1 het eind bereikt, dan stopt het programma, maar dat is niet perse een probleem.
        
    }

    
}

