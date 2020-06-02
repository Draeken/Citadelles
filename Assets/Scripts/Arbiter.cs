using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbiter : MonoBehaviour
{
    [SerializeField]
    [Range(4, 6)]
    private int PlayerCount = 6;

    [SerializeField]
    private Candidate candidatePlayer = null;

    [SerializeField]
    private Candidate candidatePrefab = null;

    [SerializeField]
    private GameObject playersTable = null;

    [SerializeField]
    private GameObject deckGameObject = null;

    private List<Candidate> candidates = new List<Candidate>();
    private Deck deck;

    void Awake()
    {
        candidates.Add(candidatePlayer);
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
            InitiateNewPlayer($"Player {i + 1}");
        }
        candidates.ForEach(delegate(Candidate candidat)
        {
            deck.DealToPlayer(candidat, 1);
        });
    }

    Candidate InitiateNewPlayer(string playerName)
    {
        Candidate newPlayerZone = Instantiate(candidatePrefab, playersTable.transform);
        newPlayerZone.Name = playerName;
        candidates.Add(newPlayerZone);        
        return newPlayerZone;
    }
}
