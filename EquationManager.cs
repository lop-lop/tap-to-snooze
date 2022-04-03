using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquationManager : MonoBehaviour
{
    private int firstNum;
    private int secondNum;
    private int sumNum;

    public Transform equate;

    private int firstDigit;
    private int secondDigit;
    private int chosen;

    public TapManager tap;
    // Start is called before the first frame update
    void Start()
    {
        firstNum = Random.Range (9, 20);
        secondNum = Random.Range (1, 20);
        equate.GetComponent<TMPro.TextMeshProUGUI>().text = firstNum.ToString() + " + " + secondNum.ToString() + " = ";
        sumNum = firstNum + secondNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Check ()
    {
        yield return new WaitForSeconds (0.5f);
        if (sumNum == secondDigit)
        {
            tap.onTap ();
        }
        else
        {
            firstDigit = 0;
            equate.GetComponent<TMPro.TextMeshProUGUI>().text = firstNum.ToString() + " + " + secondNum.ToString();
        }
    }

    
    public void Place ()
    {
        if (firstDigit == 0) 
        {
            firstDigit = chosen;
            equate.GetComponent<TMPro.TextMeshProUGUI>().text = firstNum.ToString() + " + " + secondNum.ToString() + " = " + firstDigit;
        }
        else 
        {
            secondDigit = firstDigit * 10 + chosen;
            equate.GetComponent<TMPro.TextMeshProUGUI>().text = firstNum.ToString() + " + " + secondNum.ToString() + " = " + secondDigit;
            StartCoroutine (Check ());
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
