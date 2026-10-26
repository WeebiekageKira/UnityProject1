using UnityEngine;

public class variables : MonoBehaviour
{
    int age = 2;
    string name = "21";
    float saldo = 21.8f;
    bool hasKey = false;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Mijn leeftijd is " + age);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
