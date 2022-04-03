using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePlacement : MonoBehaviour
{
    public GameObject respawn;
    public ScoreCounter counter;
    public GameObject clock;
    public GameObject playerName;
    // Start is called before the first frame update
    void Start()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn");
        counter = respawn.GetComponent<ScoreCounter>();
        if (counter.finalMinutes > 9) clock.GetComponent<TMPro.TextMeshProUGUI>().text = "It's " + counter.finalHours.ToString() + ":" + counter.finalMinutes.ToString();
        else clock.GetComponent<TMPro.TextMeshProUGUI>().text = "It's " + counter.finalHours.ToString() + ":" + "0" + counter.finalMinutes.ToString();
        if (counter.finalHours < counter.fifthHours) playerName.SetActive (false);
        else if (counter.finalHours == counter.fifthHours & counter.fifthMinutes > counter.finalMinutes) playerName.SetActive (false);
        else counter.currentName = playerName.GetComponent<TMPro.TextMeshProUGUI>().text;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.finalHours < counter.fifthHours) playerName.SetActive (false);
        else if (counter.finalHours == counter.fifthHours & counter.fifthMinutes > counter.finalMinutes) playerName.SetActive (false);
        else counter.currentName = playerName.GetComponent<TMPro.TextMeshProUGUI>().text;
    }

    public void NewScore ()
    {
        counter.NewScore ();
    }
}
