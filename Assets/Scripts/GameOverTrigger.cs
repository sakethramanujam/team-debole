using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject panel;
    public GameObject[] Gates;
    public static int BoyAdder;
    public static int GirlAdder;
    public GameObject AdderDisplayBoy;
    public GameObject AdderDisplayGirl;
    // Use this for initialization
    void Start()
    {
        BoyAdder = 4;
        GirlAdder = 4;
        AdderDisplayBoy.GetComponent<Text>().text = BoyAdder.ToString();
        AdderDisplayGirl.GetComponent<Text>().text = GirlAdder.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BoyGates" || collision.gameObject.tag == "GirlGates")
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            foreach (GameObject i in Gates)
            {
                i.GetComponent<GateMovement>().movementSpeed = 0;
            }
        }


        if (collision.gameObject.tag == "AdderTrigger")
        {
            if (this.gameObject.tag == "BoyGates")
            {
                if (collision.gameObject.name == "plus3")
                {
                    BoyAdder = 3;
                    AdderDisplayBoy.GetComponent<Text>().text = BoyAdder.ToString();
                }

                else if (collision.gameObject.name == "plus2")
                {
                    BoyAdder = 2;
                    AdderDisplayBoy.GetComponent<Text>().text = BoyAdder.ToString();
                }

                else if (collision.gameObject.name == "plus1")
                {
                    BoyAdder = 1;
                    AdderDisplayBoy.GetComponent<Text>().text = BoyAdder.ToString();
                }
            }

            if (this.gameObject.tag == "GirlGates")
            {
                if (collision.gameObject.name == "plus3")
                {
                    GirlAdder = 3;
                    AdderDisplayGirl.GetComponent<Text>().text = GirlAdder.ToString();
                }

                else if (collision.gameObject.name == "plus2")
                {
                    GirlAdder = 2;
                    AdderDisplayGirl.GetComponent<Text>().text = GirlAdder.ToString();
                }

                else if (collision.gameObject.name == "plus1")
                {
                    GirlAdder = 1;
                    AdderDisplayGirl.GetComponent<Text>().text = GirlAdder.ToString();
                }
            }
        }
    }
}
