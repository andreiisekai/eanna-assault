using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float colliderSize = 4f;
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerBoxCollider();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddNonTriggerBoxCollider()
    {
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
        boxCollider.size = new Vector3(colliderSize, colliderSize, colliderSize);
    }

    void OnParticleCollision(GameObject other)
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
