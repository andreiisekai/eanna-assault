using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private const string OnPlayerDeath = "OnPlayerDeath";
    [Tooltip("In seconds")][SerializeField] float sceneLoadDelay = 1f;
    [Tooltip("FX prefab on Player")][SerializeField] GameObject deathFx;
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
        deathFx.SetActive(true);
        SendMessage(OnPlayerDeath);
        Invoke("LoadFirstScene", sceneLoadDelay);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
