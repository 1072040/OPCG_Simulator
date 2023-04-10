using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Leader Card" , menuName = "Card/LeaderCard")]
public class LeaderCard : Card{
    public int power;
    public int life;
    public List<string> taglist;//特性
    
}