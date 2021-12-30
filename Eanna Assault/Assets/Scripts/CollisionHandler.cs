using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private const string OnPlayerDeath = "OnPlayerDeath";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        StartDeathSequence(collider);
    }

    void StartDeathSequence(Collider collider)
    {
        print("Player triggered with the gameObject -> " + collider.name);
        SendMessage(OnPlayerDeath);
    }
}
