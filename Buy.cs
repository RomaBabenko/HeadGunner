using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject buyButton, buyButton2, buyButton3;
    int buySkin, buySkin2, buySkin3;

    void Start()
    {
        buySkin = PlayerPrefs.GetInt("buySkin", 1);
        AccessUpdate();
    }

    void AccessUpdate()
    {
        buySkin2 = PlayerPrefs.GetInt("buySkin2");
        buySkin3 = PlayerPrefs.GetInt("buySkin3");
    }

    void Update()
    {
        if (buySkin == 0)                              
            buyButton.SetActive(true);
        else
            buyButton.SetActive(false);
        
        if (buySkin2 == 0)
            buyButton2.SetActive(true);
        else
            buyButton2.SetActive(false);
        
        if (buySkin3 == 0)
            buyButton3.SetActive(true);
        else
            buyButton3.SetActive(false);
    }

    public void BuySkins()
    {
        if(CoinText.money >= 5)
        {
            CoinText.money -= 5;
            PlayerPrefs.SetInt("money", CoinText.money);
            buySkin = 2;
            PlayerPrefs.GetInt("buySkin", buySkin);
        }
    }

    public void BuySkins2()
    {
        if (CoinText.money >= 1)
        {
            CoinText.money -= 1;
            PlayerPrefs.SetInt("money", CoinText.money);
            PlayerPrefs.SetInt("buySkin2", 1);
            AccessUpdate();
        }
    }

    public void BuySkins3()
    {
        if (CoinText.money >= 1)
        {
            CoinText.money -= 1;
            PlayerPrefs.SetInt("money", CoinText.money);
            PlayerPrefs.SetInt("buySkin3", 1);
            AccessUpdate();
        }
    }
}
