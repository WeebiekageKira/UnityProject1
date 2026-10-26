using UnityEngine;
public class WeaponSwitch : MonoBehaviour
{
    public int weaponSelect = 1;
    public string currentWeapon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) && weaponSelect <= 4)
        {
            weaponSelect += 1;
            switch (weaponSelect)
            {
                case 1:
                    Debug.Log("Now wielding sword");
                    break;
                case 2:
                    Debug.Log("Now stringing bow");
                    break;
                case 3:
                    Debug.Log("Now swinging staff");
                    break;
                case 4:
                    Debug.Log("Now holding dagger");
                    break;


            }
        }
        else if (weaponSelect == 5)
        {
            weaponSelect = 1;
            switch (weaponSelect)
            {
                case 1:
                    Debug.Log("Now wielding sword");
                    break;
                case 2:
                    Debug.Log("Now stringing bow");
                    break;
                case 3:
                    Debug.Log("Now swinging staff");
                    break;
                case 4:
                    Debug.Log("Now holding dagger");
                    break;


            }
        }

        
    }
}
