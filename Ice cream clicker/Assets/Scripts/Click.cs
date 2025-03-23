using UnityEngine;

public class Click : MonoBehaviour
{
    private PlayerParametrs PlayerParametrs;
    private void Start()
    {
        PlayerParametrs = GameObject.FindWithTag("PlayerParametrs").GetComponent<PlayerParametrs>();
    }

    public void Click_Coin()
    {
        PlayerParametrs.Coin += (int)(PlayerParametrs.damage * PlayerParametrs.CoinXXX);
    }

}
