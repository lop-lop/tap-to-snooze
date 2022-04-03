using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldManager : MonoBehaviour
{
    private float timePassed;

    public TapManager tap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timePassed = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (timePassed > 0.8f & timePassed < 1.2f) tap.onTap ();
        }
        timePassed += Time.deltaTime;
    }
}
