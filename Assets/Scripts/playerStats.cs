using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour
{

    private float speed = 20f; //standaard float
    private float turnSpeed = 25f; //standaard float
    private float horizontalInput; //standaard float
    private float forwardInput; //standaard float
   
    //Tip: Met een header kun je titels plaatsen in de inspector
    [Header("Character Info")]
    public string playerName = "DragonSlayer";
    public int level = 1;
    public string characterClass = "Warrior";

    public string rank = "noob";
    //add your own stats here

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;

    public int mana = 50;
    public int attack = 25;
    public int defense = 15;

    public float luck = 20.1f;
    public float stamina = 50f;

    public int specialAttack = 10;
    public int specialDefense = 15;
    //add your own stats here

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;

    public int silver = 0;
    public float playtimeHours = 2.5f;

    public bool hasCompletedTutorial = true;

    public bool completedChapter1 = false;
    //add your own stats here

    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 1;
    public string currentWeapon = "Iron Sword";

    public int staminaPotions = 3;
    public int shovel = 1;

    public string secret = "Book of Darkness";
    //add your own stats here

  


    void Start()
    {
        DisplayCharacterSheet();
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Input om stats te updaten
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * (turnSpeed * 20) * horizontalInput);

        if (level >= 10)
        {
            rank = "intermediate";
            Debug.Log("You ranked up!");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            //Level UP!
            level++;
            maxHealth += 20;
            health = maxHealth; // Full heal bij level up
            attack += 5;
            defense += 3;
            mana += 10;

            Debug.Log("LEVEL UP! Now level " + level);
            Debug.Log("Stats increased!");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Use Health Potion
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health += 30;
                if (health > maxHealth) health = maxHealth;

                Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
                Debug.Log("Potions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayCharacterSheet();
        }

        if (Input.GetKeyDown(KeyCode.R))
            {
                level = 0;
                rank = "noob";
                
            }
        //Reset Stats here when R is pressed!

    }

    private void DisplayCharacterSheet() //prive functie
    {
        //Display Character Sheet
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass);
        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Mana: " + mana);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("========================");
    }
}