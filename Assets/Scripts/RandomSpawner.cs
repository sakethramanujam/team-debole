using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject collectibleBoy;
    public GameObject collectibleGirl;
    public float repeatRate;
    public float startTime;
    float randomNumber;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("InstantiateCollectible", startTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateCollectible()
    {
        randomNumber = Random.Range(0f,100f);
        if(randomNumber<50)
        {
            Instantiate(collectibleBoy, this.gameObject.transform);
        }

        else
        {
            Instantiate(collectibleGirl, this.gameObject.transform);
        }
    }
}
