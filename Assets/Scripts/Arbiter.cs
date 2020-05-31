using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbiter : MonoBehaviour
{
    [Range(4, 6)]
    public int PlayerCount = 6;
    public GameObject playerZone;

    public GameObject deckGameObject;

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
        GameObject panel = GameObject.Find("Players");
        for (int i = 1; i < PlayerCount; i++)
        {
            InstantiateNewPlayer(panel, $"Player {i + 1}");
        }
    }

    GameObject InstantiateNewPlayer(GameObject panel, string playerName)
    {
        GameObject newPlayerZone = Instantiate(playerZone, panel.transform);
        newPlayerZone.GetComponent<Candidate>().Name = playerName;
        deck.DealToPlayer(newPlayerZone, 1);
        return newPlayerZone;
    }
}
