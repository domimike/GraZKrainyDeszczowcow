using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip CoinSound, DeadEnemySound, DeadSpikesSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        CoinSound = Resources.Load<AudioClip>("Coin");
        DeadEnemySound = Resources.Load<AudioClip>("DeadEnemy");
        DeadSpikesSound = Resources.Load<AudioClip>("DeadSpikes");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Coin":
                audioSrc.PlayOneShot(CoinSound);
                break;
            case "DeadEnemy":
                audioSrc.PlayOneShot(DeadEnemySound);
                break;
            case "DeadSpikes":
                audioSrc.PlayOneShot(DeadSpikesSound);
                break;

        }
    }
}
