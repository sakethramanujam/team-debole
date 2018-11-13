using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject panel;
    public GameObject[] Gates;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="BoyGates"||collision.gameObject.tag=="GirlGates")
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            foreach(GameObject i in Gates)
            {
                i.GetComponent<GateMovement>().movementSpeed = 0;
            }
        }
    }
}
