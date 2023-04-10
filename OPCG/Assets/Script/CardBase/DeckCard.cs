using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck Card" , menuName = "Card/DeckCard")]
public class DeckCard : Card{
    public int power;
    public List<string> taglist;//特性
    public int cost;
    public int counter;//反擊值
    public bool trigger;
}
