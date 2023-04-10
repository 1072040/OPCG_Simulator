using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay_Deck : MonoBehaviour
{
    public int id;
    public string number;
    public string imgpath;
    public Image cardImage;
    void Start() 
    {
        cardImage.sprite = Resources.Load<Sprite>(imgpath);
    }

    public void OnClick(){
        GameObject.Find("EditCardManager").GetComponent<CurrentCardDeck>().AddDeck(id);
        
    }
}

