using UnityEngine;

public class SelectSkin : MonoBehaviour
{

    public GameObject skin1, skin2, skin3;
    int selectSkin1, selectSkin2, selectSkin3;
    
    public GameObject selectButton1, selectButton2, selectButton3;
    int equipSkin1, equipSkin2, equipSkin3;

    void Start()
    {
        selectSkin1 = PlayerPrefs.GetInt("selectSkin1", 1);
        selectSkin2 = PlayerPrefs.GetInt("selectSkin2", 1);
        selectSkin3 = PlayerPrefs.GetInt("selectSkin3", 1);
        equipSkin1 = PlayerPrefs.GetInt("equipSkin1", 1);
    }

    void Update()
    {
        if(selectSkin1 == 1)
        {
            skin1.SetActive(true);
            skin2.SetActive(false);
            selectButton1.SetActive(true);
        }
        else
        {
            skin1.SetActive(false);
            selectButton1.SetActive(false);
        }

        if (selectSkin2 == 2)
        {
            skin1.SetActive(false);
            skin2.SetActive(true);
            selectButton2.SetActive(true);
        }
        else
        {
            skin2.SetActive(false);
            selectButton2.SetActive(false);
        }
       
        if (selectSkin3 == 3)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(true);
            selectButton3.SetActive(true);
        }
        else
        {
            skin3.SetActive(false);
            selectButton3.SetActive(false);
        }
    }

public void SelectOneSkin()
    {
        selectSkin1 = 1;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 1;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 1;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
        equipSkin1 = 1;
        PlayerPrefs.SetInt("equipSkin1", equipSkin1);
    }

    public void SelectTwoSkin()
    {
        selectSkin1 = 2;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 2;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 2;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
        equipSkin2 = 2;
        PlayerPrefs.SetInt("equipSkin2", equipSkin2);
    }

    public void SelectThreeSkin()
    {
        selectSkin1 = 3;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 3;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
        selectSkin3 = 3;
        PlayerPrefs.SetInt("selectSkin3", selectSkin3);
        equipSkin3 = 3;
        PlayerPrefs.SetInt("equipSkin3", equipSkin3);
    }
}
