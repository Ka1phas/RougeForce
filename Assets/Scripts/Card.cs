using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

    //Visible Information
    public Sprite Cardback { get; private set; }
    public Sprite Cardfront { get; private set; }
    public  string CardText { get; private set; }
    //implicit Information
    public int CardID { get; private set; }
    public ForcePlayer owner { get; private set; }
    public ForcePlayer controller { get; private set; }

    //Attributes
    public CardType CType { get; private set; }
    public GeneralType CGeneralType { get; private set; }
    public MagicStoneType CMagicStoneType { get; private set; }
    public string Name { get; private set; }
    public WillCost[] Cost;
    public Ability[] Abilities { get; private set; }
    public List<string> traits;
    public int AttackingPower { get; private set; }
    public int DefendingPower { get; private set; }
    public WillAttribute Attributes { get; private set; }

    public Card (int CardID, string cardText, Sprite cardfront, Sprite cardback)
    {
        this.CardText = cardText;
        this.Cardfront = cardfront;
        this.Cardback = cardback;
        this.CardID = CardID;
    }
}
