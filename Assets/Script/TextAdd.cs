using UnityEngine;
using UnityEngine.UI;

public class AddToDatabase : MonoBehaviour
{
    public InputField inputField;

    private DatabaseManager databaseManager;

    private void Start()
    {
        // El�sz�r hozz�f�r�nk a DatabaseManager script-hez
        databaseManager = FindObjectOfType<DatabaseManager>();
    }

    public void AddToDatabaseOnClick()
    {
        string inputText = inputField.text;

        if (!string.IsNullOrEmpty(inputText))
        {
            // H�vjuk meg az adatb�ziskezel� script AddData() met�dus�t a sz�veggel
            databaseManager.AddData(inputText);

            // T�r�lj�k az input mez� tartalm�t
            inputField.text = string.Empty;
        }
    }
}
