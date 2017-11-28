using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject instance;

    private bool playerA;

	
	void Start ()
    {
        instance.transform.position = spawnPoint.position;
    }
	
    
	void Update ()
    {
        HitPlayer();
        MovePlayer();
	}


    void HitPlayer()
    {
        if(Input.GetMouseButtonDown(0))
        {
            playerA = true;
        }
    }

    void MovePlayer()
    {
        if(playerA)
        {
            if (Input.GetMouseButtonDown(1))
            {
                //Dort soll dann, je nachdem wo hin geklickt wurde, die Einheit sich zur neuen Position bewegen.
                transform.position = new Vector2(1, 2); 
            }
        }
    }
}
