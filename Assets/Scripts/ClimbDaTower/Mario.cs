using UnityEngine;
using System.Linq;

public class Mario : BaseCharacterCDT {


    private void Start()
    {
        distToPlatform = transform.position.y;
    }

    private void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Mario");
    }

    void FixedUpdate () {

        GetMovement(KeyCode.A, KeyCode.D, KeyCode.W);
        
    }
}
