using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnReceiveCard(GameObject card);

public class Candidate : MonoBehaviour
{
    public event OnReceiveCard onReceiveCard;
    private List<GameObject> hand = new List<GameObject>();

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

    public void ReceiveCard(GameObject card)
    {
        hand.Add(card);     
        if (onReceiveCard != null)
        {
            onReceiveCard(card);
        }
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
