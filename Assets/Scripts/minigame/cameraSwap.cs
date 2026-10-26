using UnityEngine;


public class cameraSwap : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Movement movement;

    public int coins = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = movement.GetComponent<Movement>();
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    { 
        switch (movement.collected)
        {
            case 0:
                camera1.gameObject.SetActive(true);
                 break;
            case 2:
                camera2.gameObject.SetActive(true);
                break;
            case 6:
                camera3.gameObject.SetActive(true);
                break;
        }
        Debug.Log(movement.collected);       
    }
    
}
