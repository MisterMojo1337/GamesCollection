using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject player;
    
    private Vector3 playerMaxHeight = new Vector3();

    void Start()
    {
        playerMaxHeight = player.transform.position;
    }

    void LateUpdate()
    {
        if (player != null)
        {
            if (player.transform.position.y > playerMaxHeight.y - 2)
            {
                transform.position = new Vector3(0, player.transform.position.y, 0);
                if (player.transform.position.y > playerMaxHeight.y)
                {
                    playerMaxHeight = player.transform.position;
                }
            }
            else
            {
                transform.position = new Vector3(0, playerMaxHeight.y - 2, 0);
            }
        }

    }
}
