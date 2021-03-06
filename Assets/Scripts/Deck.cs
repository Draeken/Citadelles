﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DeckCardInfo
{
    public int count;
    public Card card;
}

public class Deck : MonoBehaviour
{
    [SerializeField]
    private List<DeckCardInfo> cardInfos = null;
    private List<Card> deck = new List<Card>();

    public void DealToPlayer(Candidate player, int count)
    {
        for (int i = 0; i < count; i++)
        {
            player.ReceiveCard(Draw());
        }
    }

    void Awake()
    {
        foreach (DeckCardInfo cardInfo in cardInfos)
        {
            for (int i = 0; i < cardInfo.count; i++)
            {
                int index = Mathf.RoundToInt(Random.Range(0, deck.Count + 1));
                deck.Insert(index, cardInfo.card);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Card Draw()
    {
        if (deck.Count <= 0)
        {
            return null;
        }
        Card card = deck[deck.Count - 1];
        deck.RemoveAt(deck.Count - 1);
        return card;
    }
    
}
