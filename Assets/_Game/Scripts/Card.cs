using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool hasBeenPlayed;

    public int handIndex;

    private CardController cc;

    private void Start()
    {
        cc = FindObjectOfType<CardController>();
    }

    private void OnMouseDown()
    {
        if(hasBeenPlayed == false)
        {
            transform.position += Vector3.forward * 2;
            hasBeenPlayed = true;
            cc.avaialableCardSlots[handIndex] = true;
            Invoke("MoveToDiscardPile", 2f);
        }
    }

    void MoveToDiscardPile()
    {
        cc.discardPile.Add(this);
        gameObject.SetActive(false);
    }
}
