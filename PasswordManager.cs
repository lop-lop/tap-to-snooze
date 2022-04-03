using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordManager : MonoBehaviour
{
    private int chosen;
    private int firstNum;
    private int secondNum;
    private int thirdNum;
    private int fourthNum;
    private int digitNum = 1;

    public Transform equate;
    public TapManager tap;
    // Start is called before the first frame update
    void Start()
    {
        firstNum = Random.Range (0, 10);
        secondNum = Random.Range (0, 10);
        thirdNum = Random.Range (0, 10);
        fourthNum = Random.Range (0, 10);
        equate.GetComponent<TMPro.TextMeshProUGUI>().text = firstNum.ToString() + secondNum.ToString() + thirdNum.ToString() + fourthNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Place ()
    {
        if (digitNum == 1)
        {
            if (chosen == firstNum)
            {
                equate.GetComponent<TMPro.TextMeshProUGUI>().text = "x" + secondNum.ToString() + thirdNum.ToString() + fourthNum.ToString();
                digitNum ++;
            }
        }
        else if (digitNum == 2)
        {
            if (chosen == secondNum) 
            {
                equate.GetComponent<TMPro.TextMeshProUGUI>().text = "xx" + thirdNum.ToString() + fourthNum.ToString();
                digitNum ++;
            }
        }
        else if (digitNum == 3)
        {
            if (chosen == thirdNum) 
            {
                equate.GetComponent<TMPro.TextMeshProUGUI>().text = "xxx" + fourthNum.ToString();
                digitNum ++;
            }
        }
        else if (digitNum == 4)
        {
            if (chosen == fourthNum) 
            {
                equate.GetComponent<TMPro.TextMeshProUGUI>().text = "xxxx";
                tap.onTap ();
            }
        }
        
    }

    public void Zero ()
    {
        chosen = 0;
        Place ();
    }
    public void One ()
    {
        chosen = 1;
        Place ();
    }
    public void Two ()
    {
        chosen = 2;
        Place ();
    }
    public void Three ()
    {
        chosen = 3;
        Place ();
    }
    public void Four ()
    {
        chosen = 4;
        Place ();
    }
    public void Five ()
    {
        chosen = 5;
        Place ();
    }
    public void Six ()
    {
        chosen = 6;
        Place ();
    }
    public void Seven ()
    {
        chosen = 7;
        Place ();
    }
    public void Eight ()
    {
        chosen = 8;
        Place ();
    }
    public void Nine ()
    {
        chosen = 9;
        Place ();
    }
}
