using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 2f;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        Invoke("LoadFirstScene", sceneLoadDelay);
    }

    void LoadFirstScene()
    {

        SceneManager.LoadScene(1);
    }
}
