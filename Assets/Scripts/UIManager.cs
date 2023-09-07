using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text currentTimeText;
    [SerializeField] private GameObject player;
    private TMP_Text playerName;

    private void Awake()
    {
        playerName = player.transform.Find("Canvas").Find("PlayerName").GetComponent<TMP_Text>();
        playerName.text = PlayerPrefs.GetString("PlayerName");
    }

    void Update()
    {
        DisplayCurrentTime();
    }

    void DisplayCurrentTime()
    {
        string time = DateTime.Now.ToString("HH:mm:ss");
        currentTimeText.text = time;
    }
}
