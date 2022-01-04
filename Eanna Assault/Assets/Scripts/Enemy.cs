using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    ScoreBoard scoreBoard;
    float colliderSize = 4f;
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 12;
    [SerializeField] int healthPoints = 100;
    [SerializeField] int healthPointsPerHit = 10;

    // Start is called before the first frame update
    void Start()
    {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddBoxCollider()
    {
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
        //boxCollider.size = new Vector3(colliderSize, colliderSize, colliderSize);
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (healthPoints <= 0)
        {
            KillEnemy();
        }
    }

    void ProcessHit()
    {
        healthPoints = healthPoints - healthPointsPerHit;
        scoreBoard.ScoreHit(scorePerHit);
    }

    void KillEnemy()
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(transform.parent.gameObject);
    }
}
