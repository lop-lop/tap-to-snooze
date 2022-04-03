using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SwipeManager : MonoBehaviour
{
    private float xOne;
    private float xTwo;
    private float yOne;
    private float yTwo;

    private int direct;

    public GameObject equate;
    public TapManager tap;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        direct = Random.Range (1, 5);
        if (direct == 1) equate.GetComponent<TMPro.TextMeshProUGUI>().text = "Swipe up to snooze";
        if (direct == 2) equate.GetComponent<TMPro.TextMeshProUGUI>().text = "Swipe right to snooze";
        if (direct == 3) equate.GetComponent<TMPro.TextMeshProUGUI>().text = "Swipe down to snooze";
        if (direct == 4) equate.GetComponent<TMPro.TextMeshProUGUI>().text = "Swipe left to snooze";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            xOne = Input.mousePosition.x;
            yOne = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp(0))
        {
            source.Play ();
            xTwo = Input.mousePosition.x;
            yTwo = Input.mousePosition.y;
            Check ();
        }
    }


    void Check ()
    {
        if (direct == 1)
        {
            if (yOne < yTwo) End();
        }
        else if (direct == 2)
        {
            if (xOne < xTwo) End();
        }
        else if (direct == 3)
        {
            if (yOne > yTwo) End();
        }
        else
        {
            if (xOne > xTwo) End();
        }
    }


    void End ()
    {
        tap.onTap ();
    }

    
}
