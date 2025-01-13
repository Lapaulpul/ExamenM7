using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger gameManger;
    public int Coins = 0;
    private void Awake()
    {
        if (GameManger.gameManger != null && GameManger.gameManger != this)
            Destroy(gameObject);

        else
        {
            GameManger.gameManger = this;
            DontDestroyOnLoad(gameManger);
        }
    }

    public void Coincollected()
    {
        Coins++;
   
        Debug.Log("Coins)");
    }
}
