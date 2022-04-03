using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject clock;
    private float myMinutes = -10;
    private int roundMinutes;
    private int oldMinutes;
    private int myHours = 5;
    private float currentTime;

    public float score;
    public int finalHours;
    public int finalMinutes;
    public Slider slider;
    public GameObject respawn;
    public ScoreCounter counter;

    public GameObject panel;
    public Animator anim;

    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad (gameObject);
        StartCoroutine (Go ());
        StartCoroutine (FadeIn ());
    }

    // Update is called once per frame
    void Update()
    {
        myMinutes += Time.deltaTime;
        roundMinutes = (int) Mathf.Round(myMinutes) * 5;
        if (roundMinutes > oldMinutes) Second ();
        score += Time.deltaTime;
        slider.value = score;
        if (score > 15) StartCoroutine (Death ());
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded (Scene scene, LoadSceneMode mode)
    {
        score -= 2; 
        myMinutes += 10;
    }

    IEnumerator Go ()
    {
        yield return new WaitForSeconds(.5f);
        myMinutes = 0;
        yield return new WaitForSeconds(.5f);
        myMinutes = 0;
        score = 0;
        SceneManager.LoadScene ("Tap");
    }

    void Second ()
    {
        oldMinutes = roundMinutes;
        if (oldMinutes > 59) 
        {
            myHours ++;
            myMinutes = -0.5f;
            oldMinutes = 0;
        }
        if (oldMinutes > 9) clock.GetComponent<TMPro.TextMeshProUGUI>().text = myHours.ToString() + ":" + oldMinutes.ToString();
        else clock.GetComponent<TMPro.TextMeshProUGUI>().text = myHours.ToString() + ":" + "0" + oldMinutes.ToString();
    }

    IEnumerator Death ()
    {
        finalHours = myHours;
        finalMinutes = oldMinutes;
        panel.SetActive(true);
        anim.SetBool("up", true);
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene("WinScreen");
        respawn = GameObject.FindGameObjectWithTag("Respawn");
        counter = respawn.GetComponent<ScoreCounter>();
        counter.finalHours = finalHours;
        counter.finalMinutes = finalMinutes;
        StartCoroutine (GoodBye ());
    }

    IEnumerator GoodBye ()
    {
        yield return new WaitForSeconds (0f);
        Destroy (gameObject);
    }

    IEnumerator FadeIn ()
    {
        source.Play ();
        yield return new WaitForSeconds(1);
        while (currentTime < 2)
        {
            currentTime += Time.deltaTime;
            source.volume = Mathf.Lerp(0, 1, currentTime);
            yield return null;
        }
        currentTime = 0;
    }

}
