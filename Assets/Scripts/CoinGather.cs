using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGather : MonoBehaviour
{
    public int pointsToAdd;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<PlayerPlatformerController>() == null)
            return;
        ScoreManager.AddPoints(pointsToAdd);
        
        

        Destroy(gameObject);
        SoundManagerScript.PlaySound("Coin");
    }
}
