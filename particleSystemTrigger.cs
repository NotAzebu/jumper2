using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleSystemTrigger : MonoBehaviour
{
    void Start()
    {
        GetComponent<ParticleSystem>().Pause();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Player Entered Collider2D");
            GetComponent<ParticleSystem>().Play();
        }
    }
    void OnCollisionExit2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Player Left Collider2D");
            GetComponent<ParticleSystem>().Stop();
        }
    }
}
