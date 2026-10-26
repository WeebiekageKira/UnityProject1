using NUnit.Framework.Internal;
using System;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public String nextSong; //waarde wordt toegevoegd in editor
    
  bool IsPlaying;
    int setVolume = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlaySong(nextSong);


        //IsPlaying("Minecraft");
    }

    // Update is called once per frame
    void Update()
    {
       // string song = "minecraft";
       if (Input.GetKeyDown(KeyCode.K))
        {
            SetVolume(1);
        }
       else if (Input.GetKeyDown(KeyCode.L))
        {
            SetVolume(2);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }

        CurrentSong(nextSong); //Wordt altijd aangeroepen


    }



    void PlaySong(string song)
    {
        Debug.Log($"Now playing: {song}");
    }

    void StopSong()
    {
        Debug.Log("Song stopped.");
    }

    //bool IsPlaying(string song)
    //{
    //    if (!IsPlaying(song))
    //    {
    //        Debug.Log("The current song is not playing.");
    //    }
    //    return false;
    //}

    string CurrentSong(string current)
    {
         if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log($"Currently Playing: {current}");
        }

         return current; //moet een return hebben

    }

    void SetVolume(int adjust)
    {
        
        if (adjust == 1 && setVolume < 10)
        {
            setVolume += 1;
            Debug.Log($"The volume is {setVolume}");
            
        }
        else if (adjust == 2 && setVolume > 0)
        {
            setVolume -= 1;
            Debug.Log($"The volume is {setVolume}");
        }
        else if (setVolume == 10 && adjust == 1)
        {
            Debug.Log("The volume is max.");
        }
        else if (setVolume == 0 && adjust == 2)
        {
            Debug.Log("The volume is off.");
        }
    }

//    void PlaySong(string songName)
//void StopSong()
//void SetVolume(float volume)
//string GetCurrentSong()s
//bool IsPlaying()
}
