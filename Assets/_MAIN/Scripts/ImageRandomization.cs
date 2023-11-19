using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(AudioSource))]
public class ImageRandomization : MonoBehaviour
{
    System.Random randomizer = new System.Random();
    
    public void Randomize() 
    {
        Image cat;
        AudioSource boom;
        cat = gameObject.GetComponent<Image>();
        boom = gameObject.GetComponent<AudioSource>();
        int spriteNum = randomizer.Next(1, 11);
        cat.sprite = Resources.Load<Sprite>($"{spriteNum}");
        boom.Play(0);
    }

}
