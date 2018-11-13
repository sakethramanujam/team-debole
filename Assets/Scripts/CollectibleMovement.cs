using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleMovement : MonoBehaviour
{
    public float movementSpeed;
    public GameObject[] boyGates;
    public GameObject[] girlGates;
    public float doorPush;
    Vector3 tmp;
    // Use this for initialization
    void Start()
    {
        boyGates = GameObject.FindGameObjectsWithTag("BoyGates");
        girlGates = GameObject.FindGameObjectsWithTag("GirlGates");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.up * movementSpeed);
    }

    private void OnMouseDown()
    {
        if (this.gameObject.tag == "collectibleBoy")
        {
            foreach (GameObject i in boyGates)
            {
                if(i.gameObject.name=="GateLeft")
                {
                    tmp = i.transform.position;
                    tmp.x -= doorPush;
                    i.transform.position = tmp;
                }

                else
                {
                    tmp = i.transform.position;
                    tmp.x += doorPush;
                    i.transform.position = tmp;
                }
            }
            Destroy(this.gameObject);
        }

        else
        {
            foreach (GameObject i in girlGates)
            {
                if (i.gameObject.name == "GateLeft")
                {
                    tmp = i.transform.position;
                    tmp.x -= doorPush;
                    i.transform.position = tmp;
                }

                else
                {
                    tmp = i.transform.position;
                    tmp.x += doorPush;
                    i.transform.position = tmp;
                }
            }
            Destroy(this.gameObject);
        }
    }
}
