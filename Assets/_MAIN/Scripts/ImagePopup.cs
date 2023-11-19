using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePopup : MonoBehaviour
{
    public Animator anim;

    public void Show()
    {
        anim.SetTrigger("Show");
    }
}
