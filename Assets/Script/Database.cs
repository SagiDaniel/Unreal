using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    private List<string> data = new List<string>();
    void Start()
    {
        // Felt�lt�s sz�vegekkel
        data.Add("Mindenki iszik");
        data.Add("L�nyok isznak");
        data.Add("Fi�k isznak");

        // Ki�r�s a konzolra
        foreach (string szoveg in data)
        {
            Debug.Log(szoveg);
        }
    }
    public void AddData(string newData)
    {
        data.Add(newData);
        Debug.Log("Adat hozz�adva az adatb�zishoz: " + newData);
    }

    public void GetData()
    {
        foreach (string item in data)
        {
            Debug.Log("Adat: " + item);
        }
    }
}
