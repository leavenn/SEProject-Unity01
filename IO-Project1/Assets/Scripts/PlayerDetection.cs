using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public GameManager _refGameManager;
    void FixedUpdate()
    {
        if(transform.position.y < 94f)
        {
            _refGameManager.GameOver();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            _refGameManager.GameOver();
        }
        
    }
}
