using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    private TopDownCharacterController _controller;

    [SerializeField] private SpriteRenderer characterRender;
    [SerializeField] private SpriteRenderer aimIcon;
    [SerializeField] private Transform iconRotation;
 
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += Look;
    }

    private void Look(Vector2 aimRotation)
    {
        RotateAim(aimRotation);
    }

    void RotateAim(Vector2 aimDirection)
    {
        float rotationZ = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        // aimIcon.flipY = Mathf.Abs(rotationZ) > 90f;
        characterRender.flipX = Mathf.Abs(rotationZ) > 90f;

        iconRotation.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}
