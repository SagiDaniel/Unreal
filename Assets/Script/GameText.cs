using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatabaseManagers : MonoBehaviour
{
    public Text runText;

    private List<string> data = new List<string>();

    public void AddData(string newData)
    {
        data.Add(newData);
        Debug.Log("Adat hozzáadva az adatbázishoz: " + newData);
    }

    public void GetRandomData()
    {
        if (data.Count > 0)
        {
            int randomIndex = Random.Range(0, data.Count);
            string randomData = data[randomIndex];
            runText.text = randomData;
        }
        else
        {
            Debug.LogWarning("Az adatbázis üres.");
        }
    }
}
