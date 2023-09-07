using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void DecidePlayName()
    {
        string nameTextString = nameInput.GetComponent<TMP_InputField>().text;

        if (nameTextString.Length > 2 && nameTextString.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", nameTextString);

            SceneManager.LoadScene("MainScene");
        }
    }
}
