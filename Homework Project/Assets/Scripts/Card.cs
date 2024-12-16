using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    public TextMeshProUGUI HpNumbertext;
    public TextMeshProUGUI specialMovetext;
    public GameObject rarityObject; 

    public string currentHp;
    public string currentMove;
    public GameObject currentRarity;
    public string currentReset;


    // Start is called before the first frame update
    void Start()
    {
        currentHp = HpNumbertext.text;
        currentMove = specialMovetext.text;
        currentRarity = rarityObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   //Function that changes Hp for Take Damage button.
    public void TakeDamage (string damageText)
    {
        currentHp = damageText; 
        HpNumbertext.text = damageText;

    }

    //Function that changes Hp for Full Heal button.
    public void FullHeal (string healText)
    {
        currentHp = healText;
        HpNumbertext.text = healText;
    }

    //Function that changes Moves for Special Move button.
    public void ChangeMove (string moveText)
    {
        currentMove = moveText;
        specialMovetext.text = moveText;
    }

    //Function that changes Image for Rarity
    public void ChangeRarity (GameObject newRare)
    {
        currentRarity = newRare;
        rarityObject = newRare;
    }

}
