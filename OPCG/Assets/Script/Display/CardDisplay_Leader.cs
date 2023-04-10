using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay_Leader : MonoBehaviour
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
        //尋找currentdeck.leader_id = id
        //呼叫顯示leader prefab
    }
}
