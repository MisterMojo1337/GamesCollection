using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetControls : MonoBehaviour {

    public Text inpJump;
    public Text inpLeft;
    public Text inpRight;


    public void Ready()
    {
        Debug.Log(inpJump.text + " " + inpLeft.text + " " + inpRight.text);
    }
}
