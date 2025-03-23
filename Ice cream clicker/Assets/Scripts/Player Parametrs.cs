using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParametrs : MonoBehaviour
{
    /// <summary>
    /// все параметры игрока
    /// </summary>
    
    #region Player


    public int damage = 0;
    public int temperature = 0;
    public int energe = 0;
    public float CoinXXX = 0;
    public int Coin = 0;
    public int pd = 0;

    #endregion


    /// <summary>
    /// все параметры мороженного
    /// </summary>
    
    #region Ice Cream


    public int[] hp = new int[] { 10,20,30,40};
    public int hp_now = 10;
    public int[] snow_Support = new int[] { 10, 20, 30, 40 };
    public int number_ice_cream = 0;

    #endregion

    private void Start()
    {
        if (!PlayerPrefs.HasKey("damage")) {
            PlayerPrefs.SetInt("damage",1);
            PlayerPrefs.SetInt("temperature",0);
            PlayerPrefs.SetInt("energe",5);
            PlayerPrefs.SetFloat("CoinXXX",1f);
            PlayerPrefs.SetInt("Coin",0);
            PlayerPrefs.SetInt("pd",0);
            PlayerPrefs.SetInt("number_ice_cream",0);
        }
        damage = PlayerPrefs.GetInt("damage");
        temperature = PlayerPrefs.GetInt("temperature");
        energe = PlayerPrefs.GetInt("energe");
        CoinXXX = PlayerPrefs.GetFloat("CoinXXX");
        Coin = PlayerPrefs.GetInt("Coin");
        pd = PlayerPrefs.GetInt("pd");
        number_ice_cream = PlayerPrefs.GetInt("number_ice_cream");
        hp_now = hp[number_ice_cream];
    }

}
