using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocks_Screen : MonoBehaviour
{

    public GameObject screen;

    public Image button;

    public Sprite open;
    public Sprite closed;

    bool isOpen = false;


    public catchL scatch;



    public void Toggle()
    {

        if (isOpen == false && scatch.paused == false && scatch.bobbing == false)
        {
            button.sprite = open;

            screen.SetActive(true);

            isOpen = true;

            scatch.paused = true;
            scatch.blur.SetActive(true);

        }else if (isOpen == true)
        {

            button.sprite = closed;

            screen.SetActive(false);

            isOpen = false;

            scatch.paused = false;
            scatch.blur.SetActive(false);
        }
    }
}
