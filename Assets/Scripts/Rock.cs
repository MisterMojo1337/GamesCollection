using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    public Transform plane;
    public Transform rock;

	void Update() {
        DestroyRock();
	}

    void DestroyRock()
    {
        if (rock.position.y <= plane.position.y)
        {
            Destroy(gameObject);
        }
    }
}
