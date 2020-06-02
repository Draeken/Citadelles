using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbiter : MonoBehaviour
{
    [SerializeField]
    [Range(4, 6)]
    private int PlayerCount = 6;

    [SerializeField]
    private Candidate playerZone = null;

    [SerializeField]
    private GameObject playersTable = null;

    [SerializeField]
    private GameObject deckGameObject = null;

    private Deck deck;

    void Awake()
    {
        deck = deckGameObject.GetComponent<Deck>();
    }

    // Start is called before the first frame update
    void Start()
    {
        SetupPlayers();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetupPlayers()
    {
        for (int i = 1; i < PlayerCount; i++)
        {
            InstantiateNewPlayer($"Player {i + 1}");
        }
    }

    Candidate InstantiateNewPlayer(string playerName)
    {
        Candidate newPlayerZone = Instantiate(playerZone, playersTable.transform);
        newPlayerZone.Name = playerName;
        deck.DealToPlayer(newPlayerZone, 1);
        return newPlayerZone;
    }
}
