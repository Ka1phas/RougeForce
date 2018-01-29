using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Zone : MonoBehaviour {

    private List<Card> cards;

    public Zone()
    {
        this.cards = new List<Card>();
    }

    public Zone(List<Card> cards)
    {
        this.cards = cards;
    }
	
	public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public void removeCard(Card card)
    {
        cards.Remove(card);
    }

    public Card removeCardAtIndex(int index)
    {
        return cards[index];
    }
}
