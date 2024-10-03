using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class catchL : MonoBehaviour
{
    public int chance = 10;

    int what;

    private float timer = 0;
    public TMP_Text cat;
    private float delay = 60;

    int count;

    public TMP_Text countDisplay;

    public bool paused = false;
    public bool unlocking = false;
    public GameObject blur;

    public unlocks sn;

    public bool bobbing = false;

    public Slider slider;

    public TextMeshProUGUI percent;

    public float bobbingHeight = 0.5f; // Adjust this value to set the bobbing height
    public float bobbingSpeed = 2.0f; // Adjust this value to set the bobbing speed

    public GameObject wall;

    private Vector3 initialPosition;

    [SerializeField] Slider musicSlider;
    [SerializeField] Slider soundSlider;


    [SerializeField] AudioSource music;
    [SerializeField] AudioSource sound;
    [SerializeField] AudioSource bobSound;

    public void MusicVolume()
    {
        music.volume = musicSlider.value;
    }

    public void SoundVolume()
    {
        sound.volume = soundSlider.value;
        bobSound.volume = soundSlider.value;
    }

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = wall.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (paused == false)
        {
            timer += 1;

            if (timer >= 300 && timer < (300 + delay))
            {
                cat.text = "CATCH";
                bobbing = true;
                if (bobSound.isPlaying == false)
                {
                    bobSound.Play();
                }
            }
            if (timer >= (300 + delay))
            {
                timer = Random.Range(1, 180);
                cat.text = "chill2";
                bobbing = false;
                bobSound.Stop();
                bobSound.time = Random.Range(0f, bobSound.clip.length);
                wall.transform.position = initialPosition;
                delay = Random.Range(180, 300f);
            }
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Debug.Log("Adios");
            Application.Quit(); 
        }

        if (Input.GetMouseButtonDown(0) && timer >= 300 && timer < (300 + delay) && paused == false)
        {
            timer = Random.Range(1, 180);
            cat.text = "chill";
            bobbing = false;
            bobSound.Stop();
            bobSound.time = Random.Range(0f, bobSound.clip.length);
            wall.transform.position = initialPosition;
            delay = Random.Range(180, 300f);

            CatchFish();
        }

        if (Input.GetMouseButtonDown(0) && unlocking == true && paused == true)
        {
            sn.unlockText.gameObject.SetActive(false);
            unlocking = false;
            paused = false;
            blur.SetActive(false);
        }

        if (bobbing == true)
        {
            BobObject();
        }

    }

    private void CatchFish()
    {
        count += 1;
        what = Random.Range(1, 101);

        if (what <= chance && sn.allUnlocked == false)
        {
            sn.UnlockBobber();
            if (sn.blobber.Count == 0)
            {
                sn.allUnlocked = true;
            }
        }else
        {
            sn.Fish();
        }

        countDisplay.text = "Catches: " + count;

    }

    public void ChangeChance()
    {
        chance = (int)slider.value;
        percent.text = chance.ToString() + "%";

    }

    void BobObject()
    {
        float yPosition = initialPosition.y + Mathf.Sin(Time.time * bobbingSpeed) * bobbingHeight;
        wall.transform.position = new Vector3(wall.transform.position.x, yPosition, wall.transform.position.z);
    }
}
