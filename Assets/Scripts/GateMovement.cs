using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMovement : MonoBehaviour
{
    //public bool rightGate;
    //public bool leftGate;
    public float movementSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if(leftGate)
        //{
            this.transform.Translate(Vector2.left * movementSpeed);
        //}

        //else
        //{
        //    this.transform.Translate(Vector2.left * movementSpeed);
        //}
    }
}
