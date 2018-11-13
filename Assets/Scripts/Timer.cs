using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public GameObject[] Gates;
    public GameObject panel;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        this.GetComponent<Text>().text = timeLeft.ToString();
        if (timeLeft <=0)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            foreach (GameObject i in Gates)
            {
                i.GetComponent<GateMovement>().movementSpeed = 0;
            }
        }
    }
}
