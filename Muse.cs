using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Muse : MonoBehaviour
{
    public AudioSource source;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (FadeIn ());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded (Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 4) StartCoroutine (FadeOut ());
        else if (scene.buildIndex == 11) StartCoroutine (FadeIn ());
    }

    IEnumerator FadeIn ()
    {
        source.Play ();
        while (currentTime < 2)
        {
            currentTime += Time.deltaTime;
            source.volume = Mathf.Lerp(0, 1, currentTime);
            yield return null;
        }
        currentTime = 0;
    }

    IEnumerator FadeOut ()
    {
        while (currentTime < 2)
        {
            currentTime += Time.deltaTime;
            source.volume = Mathf.Lerp(1, 0, currentTime);
            yield return null;
        }
        source.Stop ();
        currentTime = 0;
    }
}
