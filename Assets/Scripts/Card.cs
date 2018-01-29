using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

    public Sprite Cardback { get; private set; }
    public Sprite Cardfront { get; private set; }
    public  string CardText { get; private set; }
    public int CardID { get; private set; }
    public int itemID { get; private set; }

    public Card (int CardID, string cardText, Sprite cardfront, Sprite cardback)
    {
        this.CardText = cardText;
        this.Cardfront = cardfront;
        this.Cardback = cardback;
        this.CardID = CardID;
    }
}
