using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentCardDeck : MonoBehaviour
{
    public GameObject showplace;

    public string C_DeckName;
    public int C_Leader;
    public List<int> C_Deck;

    public void AddDeck(int c_id){
        
        if(C_Deck.Count <50){
            int over4 = 0;
            foreach (int id in C_Deck)
            {   if(id == c_id) over4 ++;    }

            if (over4 < 4)
            {   
                C_Deck.Add(c_id);   
                //生成卡片在showPlace
                Debug.Log("生成"+c_id);
            }
        }
    }

}
