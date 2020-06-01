using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DeckCardInfo
{
    public int count;
    public GameObject card;
}

public class Deck : MonoBehaviour
{
    public List<DeckCardInfo> cardInfos;
    private List<GameObject> deck = new List<GameObject>();

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
                int index = Mathf.RoundToInt(Random.Range(0, deck.Count - 1));
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

    GameObject Draw()
    {
        if (deck.Count <= 0)
        {
            return null;
        }
        GameObject card = deck[deck.Count - 1];
        deck.RemoveAt(deck.Count - 1);
        return card;
    }
    
}
