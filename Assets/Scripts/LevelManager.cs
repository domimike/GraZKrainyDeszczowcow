using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckpoint;


    private PlayerPlatformerController player;

    public GameObject deathParticle;
    public GameObject respawnParticle;

    public float respawnDelay;

    private float gravityStore;

    public int pointPenaltyOnDeath;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerPlatformerController>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);

        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;

        gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;

        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        ScoreManager.AddPoints(-pointPenaltyOnDeath);

        Debug.Log("Player Respawn");

        yield return new WaitForSeconds(respawnDelay);

        player.GetComponent<Rigidbody2D>().gravityScale = 3;
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;

        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
    }
    
}
