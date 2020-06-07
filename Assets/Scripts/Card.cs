using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CardKind
{
    A,
    B,
    C,
    D
}

public class Card : MonoBehaviour
{    
    [SerializeField]
    private int value = 0;
    [SerializeField]
    private CardKind kind = CardKind.A;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
