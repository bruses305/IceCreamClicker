using UnityEngine;
using UnityEngine.UI;
using System;

public class GameControlor : MonoBehaviour
{
    public Text Coin_Count_Text;
    public int c;
    public bool cc;
    private string[] unit = {"", "K", "M", "B" };

    private PlayerParametrs PlayerParametrs;
    void Start()
    {
        PlayerParametrs = GameObject.FindWithTag("PlayerParametrs").GetComponent<PlayerParametrs>();

    }
    private void Update()
    {
        Coin_Count_Text.text = convert_money();
    }

    private string convert_money()
    {
        double money = PlayerParametrs.Coin;

        Debug.Log(money + "  Money");
        if (money < 1000)
        {
            return $"{money}";
        }
        int i = (int)Math.Floor(Math.Log(money,1000));
        if (i > unit.Length)
        {
            return "$$$$";
        }
        else
        {
            money = Math.Round(money / Math.Pow(1000.0,i), 1);
            return money + "" + unit[i];
        }
    }

}
