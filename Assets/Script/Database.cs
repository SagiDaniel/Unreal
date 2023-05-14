using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    private List<string> data = new List<string>();
    void Start()
    {
        // Feltöltés szövegekkel
        data.Add("Mindenki iszik");
        data.Add("Lányok isznak");
        data.Add("Fiúk isznak");

        // Kiírás a konzolra
        foreach (string szoveg in data)
        {
            Debug.Log(szoveg);
        }
    }
    public void AddData(string newData)
    {
        data.Add(newData);
        Debug.Log("Adat hozzáadva az adatbázishoz: " + newData);
    }

    public void GetData()
    {
        foreach (string item in data)
        {
            Debug.Log("Adat: " + item);
        }
    }
}
