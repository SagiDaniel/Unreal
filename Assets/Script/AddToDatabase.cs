using UnityEngine;
using UnityEngine.UI;

public class AddToDatabases : MonoBehaviour
{
    public InputField inputField;

    private DatabaseManager databaseManager;

    private void Start()
    {
        databaseManager = FindObjectOfType<DatabaseManager>();
    }

    public void AddToDatabaseOnClick()
    {
        string inputText = inputField.text;

        if (!string.IsNullOrEmpty(inputText))
        {
            databaseManager.AddData(inputText);
            inputField.text = string.Empty;
        }
    }
}
