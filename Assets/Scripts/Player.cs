using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject hand = null;
    private Candidate myCandidate;

    void Awake()
    {
        myCandidate = GetComponent<Candidate>();
        myCandidate.onReceiveCard += DebugNewCards;        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DebugNewCards(Card card)
    {
        Instantiate(card, hand.transform);
        print($"card to debug {card.name}");
    }
}
