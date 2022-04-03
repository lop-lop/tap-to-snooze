using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public int finalHours;
    public int finalMinutes;
    public int firstHours;
    public int firstMinutes;
    public int secondHours;
    public int secondMinutes;
    public int thirdHours;
    public int thirdMinutes;
    public int fourthHours;
    public int fourthMinutes;
    public int fifthHours;
    public int fifthMinutes;

    public string first;
    public string second;
    public string third;
    public string fourth;
    public string fifth;

    public string currentName;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine (Go ());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit ();
    }

    

    public void NewScore ()
    {
        if (finalHours > firstHours) ChangeFirst ();
        else if (finalHours == firstHours & finalMinutes > firstMinutes) ChangeFirst ();
        else if (finalHours > secondHours) ChangeSecond ();
        else if (finalHours == secondHours & finalMinutes > secondMinutes) ChangeSecond ();
        else if (finalHours > thirdHours) ChangeThird ();
        else if (finalHours == thirdHours & finalMinutes > thirdMinutes) ChangeThird ();
        else if (finalHours > fourthHours) ChangeFourth ();
        else if (finalHours == fourthHours & finalMinutes > fourthMinutes) ChangeFourth ();
        else if (finalHours > fifthHours) ChangeFifth ();
        else if (finalHours == fifthHours & finalMinutes > fifthMinutes) ChangeFifth ();
    }

    public void ChangeFirst ()
    {
        fifthHours = fourthHours;
        fifthMinutes = fourthMinutes;
        fifth = fourth;
        fourthHours = thirdHours;
        fourthMinutes = thirdMinutes;
        fourth = third;
        thirdHours = secondHours;
        thirdMinutes = secondMinutes;
        third = second;
        secondHours = firstHours;
        secondMinutes = firstMinutes;
        second = first;
        firstHours = finalHours;
        firstMinutes = finalMinutes;
        first = currentName;
    }

    public void ChangeSecond ()
    {
        fifthHours = fourthHours;
        fifthMinutes = fourthMinutes;
        fifth = fourth;
        fourthHours = thirdHours;
        fourthMinutes = thirdMinutes;
        fourth = third;
        thirdHours = secondHours;
        thirdMinutes = secondMinutes;
        third = second;
        secondHours = finalHours;
        secondMinutes = finalMinutes;
        second = currentName;
    }

    public void ChangeThird ()
     {
        fifthHours = fourthHours;
        fifthMinutes = fourthMinutes;
        fifth = fourth;
        fourthHours = thirdHours;
        fourthMinutes = thirdMinutes;
        fourth = third;
        thirdHours = finalHours;
        thirdMinutes = finalMinutes;
        third = currentName;
    }

    public void ChangeFourth ()
    {
        fifthHours = fourthHours;
        fifthMinutes = fourthMinutes;
        fifth = fourth;
        fourthHours = finalHours;
        fourthMinutes = finalMinutes;
        fourth = currentName;
    }

    public void ChangeFifth ()
    {
        fifthHours = finalHours;
        fifthMinutes = finalMinutes;
        fifth = currentName;
    }

    IEnumerator Go ()
    {
        yield return new WaitForSeconds (5);
        SceneManager.LoadScene(1);
    }
}
