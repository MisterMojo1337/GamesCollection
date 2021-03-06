﻿using Assets.Scripts.MP_Selector;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControls : MonoBehaviour {

    [Header("Attributes")]

    public float healthPoints = 100f;
    public float movementForce = 5f;
    public float jumpForce = 300f;

    [Header("Unity Setup Fields")]
    public GameObject graveStone;
    public SpriteRenderer flipIt;
    private float timer;
    private int jumpCounter = 1;
    private float distToGround;
    public Text playerText;

    [Header("Json Attribute")]
    private string controlPath;
    private Control[] controls = new Control[4];

    private void Start()
    {
        controlPath = Application.streamingAssetsPath + "/Controls.json";
        controls = JsonHelper.FromJson<Control>(File.ReadAllText(controlPath));
    }

    private void FixedUpdate()
    {
        var parentName = gameObject.transform.parent.name;
        var control = controls.FirstOrDefault(x => x.Id == parentName);
        GetMovement(control.InputLeft, control.InputRight, control.InputJump);
    }

    public void GetMovement(string left, string right, string up)
    {
        if (Input.GetKey(right))
        {
            transform.Translate(new Vector3(movementForce * Time.deltaTime, 0));
            flipIt.flipX = true;
        }
        if (Input.GetKey(left))
        {
            transform.Translate(new Vector3(-movementForce * Time.deltaTime, 0));
            flipIt.flipX = false;
        }
        if (Input.GetKey(up))
        {
            if (jumpCounter > 0)
            {
                //Debug.Log("jump");
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce * Time.deltaTime);
                jumpCounter--;
            }
        }
    }
    

    private void Update()
    {
        if (healthPoints <= 0)
        {
            KillEntity(gameObject);
        }
        if (jumpCounter == 0 && gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            jumpCounter = 1;
        }
        timer += Time.deltaTime;
        playerText.text = "" + timer.ToString("F2") + "";

    }
    public void KillEntity(GameObject character)
    {
        Destroy(character);
        Instantiate(graveStone, character.transform.position, character.transform.rotation);
    }
}
