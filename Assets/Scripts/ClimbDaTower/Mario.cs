using UnityEngine;
using System.Linq;

public class Mario : BaseCharacterCDT {

    private void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {        
        jumpCounter += 1;
    }

    void FixedUpdate () {

        GetMovement(KeyCode.A, KeyCode.D, KeyCode.W);
        
    }
}
