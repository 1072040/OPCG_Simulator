using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum cardcolor{
    RED,
    GREEN,
    BLUE,
    PURPLE,
    BLACK
}

public enum cardtype{
    Leader,
    Character,
    Event,
    Stage,
    Don
}

public enum attribuate{
    Strike,
    Special,
    Slash,
    Ranged,
    Wisdom,
    NONE
}

[CreateAssetMenu(fileName = "New Card" , menuName = "Card/Test")]
public class Card : ScriptableObject{
    public int id;
    public string number;//編號
    public cardcolor color;// RED GREEN BLUE PURPLE BLACK DON
    public cardtype cardType;// L:leader C:character  D:don! E:event S:stage
    public string cardName;//卡片名稱 
    public string cardPack;//卡包來源 ST01 OP01
    public Sprite cardImage;//圖片 
    public attribuate attribuate;//屬性
    public string description;//能力說明
}
