using UnityEngine;
using UnityEngine.UI;

public class AddToDatabase : MonoBehaviour
{
    public InputField inputField;

    private DatabaseManager databaseManager;

    private void Start()
    {
        // Elõször hozzáférünk a DatabaseManager script-hez
        databaseManager = FindObjectOfType<DatabaseManager>();
    }

    public void AddToDatabaseOnClick()
    {
        string inputText = inputField.text;

        if (!string.IsNullOrEmpty(inputText))
        {
            // Hívjuk meg az adatbáziskezelõ script AddData() metódusát a szöveggel
            databaseManager.AddData(inputText);

            // Töröljük az input mezõ tartalmát
            inputField.text = string.Empty;
        }
    }
}
