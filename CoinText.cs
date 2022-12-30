using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    Text CoinTexts;
    public static int money;

    void Start()
    {
        CoinTexts = GetComponent<Text>();
        money = PlayerPrefs.GetInt("money", money);
    }

    void Update()
    {
        CoinTexts.text = money.ToString();
        PlayerPrefs.SetInt("money", money);
    }
}
