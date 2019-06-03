using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private PlayerPlatformerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerPlatformerController>();
    }
    public void Arrow_Left()
    {
        Input.GetAxisRaw("Horizontal");
    }
    public void Arrow_Right()
    {
        Input.GetAxisRaw("Horizontal");
    }
    public void Arrow_Top()
    {
        Input.GetButton("Jump");
    }
}