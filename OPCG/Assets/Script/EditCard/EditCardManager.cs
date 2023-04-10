using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCardManager : MonoBehaviour
{
    public GameObject showplace;
    private string[] str;
    
    private void Start() {
        LoadCardTxt();
    }

    public void LoadCardTxt(){//
        TextAsset CardListTxt = Resources.Load("Card Information/CardList") as TextAsset;
        
        str = CardListTxt.text.Split('\n');//分行切

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }

    public void GenerateCard(string type,string id , string number ,string pack){
        if (type == "L")//分辨Leader卡
        {
            GameObject newcard = Instantiate(Resources.Load("Prefab/Leader Card Prefab") as GameObject , showplace.transform);
            CardDisplay_Leader CD_L = newcard.GetComponent<CardDisplay_Leader>();
            CD_L.id = int.Parse(id);
            CD_L.imgpath = "Image/" + pack + "/" + number;
        }
        else 
        { 
            GameObject newcard = Instantiate(Resources.Load("Prefab/Deck Card Prefab") as GameObject , showplace.transform);
            CardDisplay_Deck CD_D = newcard.GetComponent<CardDisplay_Deck>();
            CD_D.id = int.Parse(id);
            CD_D.imgpath = "Image/" + pack + "/" + number;
        }
    }

    public void RemoveCard(){
        while (showplace.transform.childCount > 0) {
        DestroyImmediate(showplace.transform.GetChild(0).gameObject);
        }
    }

    //-----------------------------------------------------------------------------------------------------
    

    public void RedColor(){
        RemoveCard();
        Debug.Log("紅");

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            if(ss[3] == "紅") GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }

    public void GreenColor(){
        RemoveCard();
        Debug.Log("綠");

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            if(ss[3] == "綠") GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }

    public void BlueColor(){
        RemoveCard();
        Debug.Log("藍");

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            if(ss[3] == "藍") GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }

    public void PurpleColor(){
        RemoveCard();
        Debug.Log("紫");

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            if(ss[3] == "紫") GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }
    public void BlackColor(){
        RemoveCard();
        Debug.Log("黑");

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            if(ss[3] == "黑") GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }
    public void WhiteColor(){
        RemoveCard();
        Debug.Log("白");

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            if(ss[3] == "白") GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }
    public void ALLColor(){
        RemoveCard();
        Debug.Log("ALL");

        foreach(string strs in str){
            string[] ss = strs.Split(',');//分標點符號切
            GenerateCard(ss[2], ss[0],ss[1],ss[5]);
        }
    }
}
