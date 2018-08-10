using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour {

    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    public GameObject buttonP2;
    public GameObject buttonP3;
    public GameObject buttonP4;

    public GameObject closeButtonP2;
    public GameObject closeButtonP3;
    public GameObject closeButtonP4;

    public void AddP2()
    {
        buttonP2.SetActive(false);
        p2.SetActive(true);
        closeButtonP2.SetActive(true);
    }

    public void AddP3()
    {
        buttonP3.SetActive(false);
        p3.SetActive(true);
        closeButtonP3.SetActive(true);
    }

    public void AddP4()
    {
        buttonP4.SetActive(false);
        p4.SetActive(true);
        closeButtonP4.SetActive(true);
    }

    public void CloseP2()
    {
        p2.SetActive(false);
        closeButtonP2.SetActive(false);
        buttonP2.SetActive(true);
    }

    public void CloseP3()
    {
        p3.SetActive(false);
        closeButtonP3.SetActive(false);
        buttonP3.SetActive(true);
    }

    public void CloseP4()
    {
        p4.SetActive(false);
        closeButtonP4.SetActive(false);
        buttonP4.SetActive(true);
    }
}
