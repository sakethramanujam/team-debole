using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterDisplay : MonoBehaviour
{
    public int NoOfBoys;
    public int NoOfGirls;
    public GameObject BoyText;
    public GameObject GirlText;
    // Use this for initialization
    void Start()
    {
        NoOfBoys = 0;
        NoOfGirls = 0;
        InvokeRepeating("Adder", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Adder()
    {
        if (this.gameObject.name == "BoyCounter")
        {
            NoOfBoys += GameOverTrigger.BoyAdder;
            BoyText.GetComponent<Text>().text = NoOfBoys.ToString();
        }

        else
        {
            NoOfGirls += GameOverTrigger.GirlAdder;
            GirlText.GetComponent<Text>().text = NoOfGirls.ToString();
        }
    }
}
