using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongManager : MonoBehaviour
{
    private int wrongNum;
    private int newNum;
    private int chosen;

    public GameObject change0;
    public GameObject change1;
    public GameObject change2;
    public GameObject change3;
    public GameObject change4;
    public GameObject change5;
    public GameObject change6;
    public GameObject change7;
    public GameObject change8;
    public GameObject change9;

    public TapManager tap;
    // Start is called before the first frame update
    void Start()
    {
        wrongNum = Random.Range (0, 10);
        newNum = Random.Range (0, 10);
        if (newNum == wrongNum) 
        {
            newNum += 1;
            if (newNum == 10) newNum = 0;
        }
        if (wrongNum == 0) change0.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 1) change1.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 2) change2.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 3) change3.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 4) change4.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 5) change5.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 6) change6.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 7) change7.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 8) change8.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
        else if (wrongNum == 9) change9.GetComponent<TMPro.TextMeshProUGUI>().text = newNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Place ()
    {
        if (chosen == wrongNum) tap.onTap ();
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
