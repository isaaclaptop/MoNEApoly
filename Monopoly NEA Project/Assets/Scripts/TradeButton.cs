using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeButton : MonoBehaviour
{
    public GameManager gameManager;

    public void OnClick()
    {
        gameManager.ShowMakingTrade();
    }
}