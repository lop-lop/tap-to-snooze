using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TapManager : MonoBehaviour
{
    public GameObject eyesIn;
    public GameObject eyesOut;
    public GameObject screen;
    public GameObject baseScreen;

    public Navigator navigator;
    public AudioSource source;
    //public AudioSource muse1;

    //public Animator eyesAnim;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (Begin ());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTap ()
    {
        StartCoroutine (End ());
    }

    IEnumerator Begin ()
    {
        eyesIn.SetActive(true);
        yield return new WaitForSeconds (1f);
        //screen.SetActive(true);
        //baseScreen.SetActive(true);
        //yield return new WaitForSeconds (0f);
        eyesIn.SetActive(false);
    }

    IEnumerator End ()
    {
        yield return new WaitForSeconds (.2f);
        eyesOut.SetActive(true);
        baseScreen.SetActive(false);
        screen.SetActive(true);
        source.Play ();
        yield return new WaitForSeconds (1);
        navigator.Next ();
    }
}
