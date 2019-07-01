using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject player;
    private float highestPoint = 0;
    private Vector3 offset;

    void Start()
    {
        highestPoint = player.transform.position.y;
        //offset = new Vector2(0, transform.position.y - player.transform.position.y);
    }

    void LateUpdate()
    {
        if (player.transform.position.y > highestPoint)
        {
            highestPoint = player.transform.position.y;
        }
        transform.position = new Vector2(0, highestPoint);
    }
}
