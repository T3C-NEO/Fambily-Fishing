using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class unlocks : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public bool allUnlocked = false;

    public Sprite soltara;

    public TMP_Text unlockText;

    public Sprite crab;
    bool crabUnlock = false;
    string crabList = "Crab";
    public Image crabSprite;

    public Sprite power;
    bool powerUnlock = false;
    string powerList = "POWER";
    public Image powerSprite;

    public Sprite bookie;
    bool bookieUnlock = false;
    string bookieList = "Bookie";
    public Image bookieSprite;

    public Sprite esperalda;
    bool esperaldaUnlock = false;
    string esperaldaList = "Esperalda";
    public Image esperaldaSprite;

    public Sprite worldEngine;
    bool worldEngineUnlock = false;
    string worldEngineList = "World Engine";
    public Image worldEngineSprite;

    public Sprite sandy;
    bool sandyUnlock = false;
    string sandyList = "Sandy";
    public Image sandySprite;

    public Sprite spooty;
    bool spootyUnlock = false;
    string spootyList = "Spooty";
    public Image spootySprite;

    public Sprite dino;
    bool dinoUnlock = false;
    string dinoList = "Dino";
    public Image dinoSprite;

    public Sprite horizon;
    bool horizonUnlock = false;
    string horizonList = "Horizon";
    public Image horizonSprite;

    public Sprite argonauts;
    bool argonautsUnlock = false;
    string argonautsList = "Argonauts";
    public Image argonautsSprite;

    public Sprite houseOwl;
    bool houseOwlUnlock = false;
    string houseOwlList = "House Owl";
    public Image houseOwlSprite;


    public List<string> blobber = new List<string>();

    public SpriteRenderer player;

    public Sprite kemperSit;

    public Sprite ant;
    public Sprite antSit;
    bool antUnlock = false;
    string antList = "Ant";
    public Image antSprite;

    public Sprite vesper;
    public Sprite vesperSit;
    bool vesperUnlock = false;
    string vesperList = "Vesper";
    public Image vesperSprite;

    public Sprite val;
    public Sprite valSit;
    bool valUnlock = false;
    string valList = "Val";
    public Image valSprite;

    public Sprite soleila;
    public Sprite soleilaSit;
    bool soleilaUnlock = false;
    string soleilaList = "Soleila";
    public Image soleilaSprite;

    public Sprite mori;
    public Sprite moriSit;
    bool moriUnlock = false;
    string moriList = "Mori";
    public Image moriSprite;

    public Sprite herakles;
    public Sprite heraklesSit;
    bool heraklesUnlock = false;
    string heraklesList = "Herakles";
    public Image heraklesSprite;

    public Sprite blitz;
    public Sprite blitzSit;
    bool blitzUnlock = false;
    string blitzList = "Blitz";
    public Image blitzSprite;

    public Sprite baba;
    public Sprite babaSit;
    bool babaUnlock = false;
    string babaList = "Baba";
    public Image babaSprite;

    public Sprite collar;
    public Sprite collarSit;
    bool collarUnlock = false;
    string collarList = "Collar";
    public Image collarSprite;

    public Sprite beasley;
    public Sprite beasleySit;
    bool beasleyUnlock = false;
    string beasleyList = "Beasley";
    public Image beasleySprite;

    public Sprite ambrosius;
    public Sprite ambrosiusSit;
    bool ambrosiusUnlock = false;
    string ambrosiusList = "Ambrosius";
    public Image ambrosiusSprite;




    public Sprite axe;
    bool axeUnlock = false;
    string axeList = "Battleaxe";
    public Image axeSprite;

    public Sprite snack;
    bool snackUnlock = false;
    string snackList = "Snicker Snack";
    public Image snackSprite;

    public Sprite staff;
    bool staffUnlock = false;
    string staffList = "Winter Staff";
    public Image staffSprite;


    public catchL scatch;

    public Image B;
    public Image rog;

    bool tempUnlocking = false;

    public GameObject fisherRod;
    public GameObject axeRod;
    public GameObject snackRod;
    public GameObject staffRod;


    public Image unlockImage;
    float[] spriteProbabilities = { 0.35f, 0.25f, 0.2f, 0.15f, 0.05f };
    public Sprite[] spriteList;


    private void Awake()
    {
        blobber.Add(crabList);
        blobber.Add(powerList);
        blobber.Add(bookieList);
        blobber.Add(esperaldaList);
        blobber.Add(worldEngineList);
        blobber.Add(sandyList);
        blobber.Add(spootyList);
        blobber.Add(dinoList);
        blobber.Add(horizonList);
        blobber.Add(argonautsList);
        blobber.Add(houseOwlList);

        blobber.Add(antList);
        blobber.Add(vesperList);
        blobber.Add(valList);
        blobber.Add(soleilaList);
        blobber.Add(moriList);
        blobber.Add(heraklesList);
        blobber.Add(blitzList);
        blobber.Add(babaList);
        blobber.Add(collarList);
        blobber.Add(beasleyList);
        blobber.Add(ambrosiusList);

        blobber.Add(axeList);
        blobber.Add(snackList);
        blobber.Add(staffList);

    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && tempUnlocking == true)
        {
            scatch.unlocking = true;
            tempUnlocking = false;
        }
    }

    public void Fish()
    {
        float randomValue = Random.value;
        float cumulativeProbability = 0f;

        // Iterate through sprite probabilities to determine which sprite to choose
        for (int j = 0; j < spriteProbabilities.Length; j++)
        {
            cumulativeProbability += spriteProbabilities[j];

            if (randomValue <= cumulativeProbability)
            {
                // Change sprite to the selected index from spriteList
                unlockText.gameObject.SetActive(true);
                B.gameObject.SetActive(true);
                unlockImage.gameObject.SetActive(false);
                rog.gameObject.SetActive(false);
                scatch.paused = true;
                scatch.blur.SetActive(true);
                tempUnlocking = true;
                B.sprite = spriteList[j];
                unlockText.text = "     caught!";
                break;
            }
        }
    }

        public void UnlockBobber()
    {
        int i = Random.Range(0, blobber.Count);
        Debug.Log(blobber[i]);

        unlockText.gameObject.SetActive(true);
        scatch.paused = true;
        scatch.blur.SetActive(true);
        tempUnlocking = true;
        B.gameObject.SetActive(false);
        rog.gameObject.SetActive(false);
        unlockImage.gameObject.SetActive(true);
        unlockText.text = "     unlocked!";

        if (blobber[i] == crabList)
        {
            crabSprite.sprite = crab;
            crabUnlock = true;
            unlockImage.sprite = crab;
            blobber.Remove(blobber[i]);


            return;
        }

        if (blobber[i] == powerList)
        {
            powerSprite.sprite = power;
            powerUnlock = true;
            unlockImage.sprite = power;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == bookieList)
        {
            bookieSprite.sprite = bookie;
            bookieUnlock = true;
            unlockImage.sprite = bookie;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == esperaldaList)
        {
            esperaldaSprite.sprite = esperalda;
            esperaldaUnlock = true;
            unlockImage.sprite = esperalda;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == worldEngineList)
        {
            worldEngineSprite.sprite = worldEngine;
            worldEngineUnlock = true;
            unlockImage.sprite = worldEngine;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == sandyList)
        {
            sandySprite.sprite = sandy;
            sandyUnlock = true;
            unlockImage.sprite = sandy;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == spootyList)
        {
            spootySprite.sprite = spooty;
            spootyUnlock = true;
            unlockImage.sprite = spooty;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == dinoList)
        {
            dinoSprite.sprite = dino;
            dinoUnlock = true;
            unlockImage.sprite = dino;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == horizonList)
        {
            horizonSprite.sprite = horizon;
            horizonUnlock = true;
            unlockImage.sprite = horizon;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == argonautsList)
        {
            argonautsSprite.sprite = argonauts;
            argonautsUnlock = true;
            unlockImage.sprite = argonauts;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == houseOwlList)
        {
            houseOwlSprite.sprite = houseOwl;
            houseOwlUnlock = true;
            unlockImage.sprite = houseOwl;
            blobber.Remove(blobber[i]);

            return;
        }
   
        if (blobber[i] == antList)
        {
            antSprite.sprite = ant;
            antUnlock = true;
            unlockImage.sprite = ant;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == vesperList)
        {
            vesperSprite.sprite = vesper;
            vesperUnlock = true;
            unlockImage.sprite = vesper;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == valList)
        {
            valSprite.sprite = val;
            valUnlock = true;
            unlockImage.sprite = val;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == soleilaList)
        {
            soleilaSprite.sprite = soleila;
            soleilaUnlock = true;
            unlockImage.sprite = soleila;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == moriList)
        {
            moriSprite.sprite = mori;
            moriUnlock = true;
            unlockImage.sprite = mori;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == heraklesList)
        {
            heraklesSprite.sprite = herakles;
            heraklesUnlock = true;
            unlockImage.sprite = herakles;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == blitzList)
        {
            blitzSprite.sprite = blitz;
            blitzUnlock = true;
            unlockImage.sprite = blitz;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == babaList)
        {
            babaSprite.sprite = baba;
            babaUnlock = true;
            unlockImage.sprite = baba;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == collarList)
        {
            collarSprite.sprite = collar;
            collarUnlock = true;
            unlockImage.sprite = collar;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == beasleyList)
        {
            beasleySprite.sprite = beasley;
            beasleyUnlock = true;
            unlockImage.sprite = beasley;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == ambrosiusList)
        {
            ambrosiusSprite.sprite = ambrosius;
            ambrosiusUnlock = true;
            unlockImage.sprite = ambrosius;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == axeList)
        {
            rog.gameObject.SetActive(true);
            unlockImage.gameObject.SetActive(false);
            axeSprite.sprite = axe;
            axeUnlock = true;
            rog.sprite = axe;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == snackList)
        {
            rog.gameObject.SetActive(true);
            unlockImage.gameObject.SetActive(false);
            snackSprite.sprite = snack;
            snackUnlock = true;
            rog.sprite = snack;
            blobber.Remove(blobber[i]);

            return;
        }

        if (blobber[i] == staffList)
        {
            rog.gameObject.SetActive(true);
            unlockImage.gameObject.SetActive(false);
            staffSprite.sprite = staff;
            staffUnlock = true;
            rog.sprite = staff;
            blobber.Remove(blobber[i]);

            return;
        }
    }

    public void Changesoltara()
    {
        spriteRenderer.sprite = soltara;
    }

    public void Changecrab()
    {
        if (crabUnlock == true)
        {
            spriteRenderer.sprite = crab;
        }
    }

    public void Changepower()
    {
        if (powerUnlock == true)
        {
            spriteRenderer.sprite = power;
        }
    }

    public void Changebookie()
    {
        if (bookieUnlock == true)
        {
            spriteRenderer.sprite = bookie;
        }
    }

    public void Changeesperalda()
    {
        if (esperaldaUnlock == true)
        {
            spriteRenderer.sprite = esperalda;
        }
    }

    public void ChangeworldEngine()
    {
        if (worldEngineUnlock == true)
        {
            spriteRenderer.sprite = worldEngine;
        }
    }

    public void Changesandy()
    {
        if (sandyUnlock == true)
        {
            spriteRenderer.sprite = sandy;
        }
    }

    public void Changespooty()
    {
        if (spootyUnlock == true)
        {
            spriteRenderer.sprite = spooty;
        }
    }

    public void Changedino()
    {
        if (dinoUnlock == true)
        {
            spriteRenderer.sprite = dino;
        }
    }

    public void Changehorizon()
    {
        if (horizonUnlock == true)
        {
            spriteRenderer.sprite = horizon;
        }
    }

    public void Changeargonauts()
    {
        if (argonautsUnlock == true)
        {
            spriteRenderer.sprite = argonauts;
        }
    }

    public void ChangehouseOwl()
    {
        if (houseOwlUnlock == true)
        {
            spriteRenderer.sprite = houseOwl;
        }
    }

    //SKINS


    public void ChangeKemper()
    {
        player.sprite = kemperSit;
    }

    public void ChangeAnt()
    {
        if (antUnlock == true)
        {
            player.sprite = antSit;
        }
    }

    public void ChangeVesper()
    {
        if (vesperUnlock == true)
        {
            player.sprite = vesperSit;
        }
    }

    public void ChangeVal()
    {
        if (valUnlock == true)
        {
            player.sprite = valSit;
        }
    }

    public void ChangeSoleila()
    {
        if (soleilaUnlock == true)
        {
            player.sprite = soleilaSit;
        }
    }

    public void ChangeMori()
    {
        if (moriUnlock == true)
        {
            player.sprite = moriSit;
        }
    }

    public void ChangeHerakles()
    {
        if (heraklesUnlock == true)
        {
            player.sprite = heraklesSit;
        }
    }

    public void ChangeBlitz()
    {
        if (blitzUnlock == true)
        {
            player.sprite = blitzSit;
        }
    }

    public void ChangeBaba()
    {
        if (babaUnlock == true)
        {
            player.sprite = babaSit;
        }
    }

    public void ChangeCollar()
    {
        if (collarUnlock == true)
        {
            player.sprite = collarSit;
        }
    }

    public void ChangeBeasley()
    {
        if (beasleyUnlock == true)
        {
            player.sprite = beasleySit;
        }
    }

    public void ChangeAmbrosius()
    {
        if (ambrosiusUnlock == true)
        {
            player.sprite = ambrosiusSit;
        }
    }

    //Rods


    public void ChangeRod()
    {
        fisherRod.SetActive(true);
        axeRod.SetActive(false);
        snackRod.SetActive(false);
        staffRod.SetActive(false);
    }

    public void ChangeAxe()
    {
        if (axeUnlock == true)
        {
            fisherRod.SetActive(false);
            axeRod.SetActive(true);
            snackRod.SetActive(false);
            staffRod.SetActive(false);
        }
    }

    public void ChangeSnack()
    {
        if (snackUnlock == true)
        {
            fisherRod.SetActive(false);
            axeRod.SetActive(false);
            snackRod.SetActive(true);
            staffRod.SetActive(false);
        }
    }

    public void ChangeStaff()
    {
        if (staffUnlock == true)
        {
            fisherRod.SetActive(false);
            axeRod.SetActive(false);
            snackRod.SetActive(false);
            staffRod.SetActive(true);
        }
    }
}
