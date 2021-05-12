using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsContainer : MonoBehaviour
{
    public static AudioSource[] sounds;
    
    void Start()
    {
        sounds = GetComponents<AudioSource>();        
    }
}
