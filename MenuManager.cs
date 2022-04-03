using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject panel;
    public Animator anim;
    private int which;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (Begin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu ()
    {
        which = 1;
        StartCoroutine (Move());
    }

    public void Rules ()
    {
        which = 2;
        StartCoroutine (Move());
    }

    public void Score ()
    {
        which = 3;
        StartCoroutine (Move());
    }

    public void Play ()
    {
        which = 4;
        StartCoroutine (Move());
    }

    IEnumerator Begin ()
    {
        yield return new WaitForSeconds(1);
        panel.SetActive(false);
    }

    IEnumerator Move ()
    {
        panel.SetActive(true);
        anim.SetBool("up", true);
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene (which);
    }


}
