using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlacement : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject fourth;
    public GameObject fifth;

    public GameObject respawn;
    public ScoreCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn");
        counter = respawn.GetComponent<ScoreCounter>();
        if (counter.fifthHours > 0) 
        {
            if (counter.fifthMinutes > 9) fifth.GetComponent<TMPro.TextMeshProUGUI>().text = counter.fifth + " - " + counter.fifthHours.ToString() + ":" + counter.fifthMinutes.ToString();
            else fifth.GetComponent<TMPro.TextMeshProUGUI>().text = counter.fifth + " - " + counter.fifthHours.ToString() + ":" + "0" + counter.fifthMinutes.ToString();
        }
        if (counter.fourthHours > 0) 
        {
            if (counter.fourthMinutes > 9) fourth.GetComponent<TMPro.TextMeshProUGUI>().text = counter.fourth + " - " + counter.fourthHours.ToString() + ":" + counter.fourthMinutes.ToString();
            else fourth.GetComponent<TMPro.TextMeshProUGUI>().text = counter.fourth + " - " + counter.fourthHours.ToString() + ":" + "0" + counter.fourthMinutes.ToString();
        }
        if (counter.thirdHours > 0) 
        {
            if (counter.thirdMinutes > 9) third.GetComponent<TMPro.TextMeshProUGUI>().text = counter.third + " - " + counter.thirdHours.ToString() + ":" + counter.thirdMinutes.ToString();
            else third.GetComponent<TMPro.TextMeshProUGUI>().text = counter.third + " - " + counter.thirdHours.ToString() + ":" + "0" + counter.thirdMinutes.ToString();
        }
        if (counter.secondHours > 0) 
        {
            if (counter.secondMinutes > 9) second.GetComponent<TMPro.TextMeshProUGUI>().text = counter.second + " - " + counter.secondHours.ToString() + ":" + counter.secondMinutes.ToString();
            else second.GetComponent<TMPro.TextMeshProUGUI>().text = counter.second + " - " + counter.secondHours.ToString() + ":" + "0" + counter.secondMinutes.ToString();
        }
        if (counter.firstHours > 0) 
        {
            if (counter.firstMinutes > 9) first.GetComponent<TMPro.TextMeshProUGUI>().text = counter.first + " - " + counter.firstHours.ToString() + ":" + counter.firstMinutes.ToString();
            else first.GetComponent<TMPro.TextMeshProUGUI>().text = counter.first + " - " + counter.firstHours.ToString() + ":" + "0" + counter.firstMinutes.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
