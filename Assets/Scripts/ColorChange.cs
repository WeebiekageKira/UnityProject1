using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ColorChange : MonoBehaviour
{
    private Renderer objectRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        objectRenderer = GetComponent<Renderer>();
        //cubeRenderer.material.SetColor("_Color", Color.red);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {

        objectRenderer.material.color = Random.ColorHSV();
        Debug.Log("Howdy");

    }

}
