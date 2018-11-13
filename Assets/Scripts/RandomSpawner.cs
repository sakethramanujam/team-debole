using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject collectible;
    public float repeatRate;
    public float startTime;
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
        Instantiate(collectible,this.gameObject.transform);
    }
}
