using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnReceiveCard(Card card);
public delegate void OnTurnSet();

public class Candidate : MonoBehaviour
{
    public event OnReceiveCard onReceiveCard;
    public event OnTurnSet onTurnSet;
    private List<Card> hand = new List<Card>();

    [SerializeField]
    private UnityEngine.UI.Text uiName = null;

    [SerializeField]
    private string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            _name = value;
            uiName.text = _name;
        }
    }

    public void ReceiveCard(Card card)
    {
        hand.Add(card);
        onReceiveCard?.Invoke(card);
    }

    public void SetMyTurn()
    {
        onTurnSet?.Invoke();
    }

    void Awake()
    {
        uiName.text = _name;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
