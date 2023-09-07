using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkSubmitButton : MonoBehaviour
{
    public GameObject player;
    private float distanceBetweenPlayer;
    private GameObject CopyButton;

    private void Awake()
    {
        
    }
    private void Update()
    {
        distanceBetweenPlayer = Vector2.Distance(player.transform.position, transform.position);
        if (distanceBetweenPlayer <= 3.0f)
        {
            gameObject.SetActive(true);
        }
    }
}
