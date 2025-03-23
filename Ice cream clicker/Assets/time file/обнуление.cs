using UnityEngine;

public class обнуление : MonoBehaviour
{
    public bool обнулить = false;
    public bool обнулитьвсё = false;
    public string[] playerprefs = new string[1];
    void Update()
    {
        if (обнулить)
        {
            for(int i = 0; i < playerprefs.Length; i++)
            {
                PlayerPrefs.DeleteKey(playerprefs[i]);
            }
            обнулить = false;
        }
        if (обнулитьвсё)
        {
            PlayerPrefs.DeleteAll();
            обнулитьвсё = false;
        }
    }
}
