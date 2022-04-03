using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    private int nextScene;
    private Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next ()
    {
        nextScene = Random.Range(6, 11);
        if (scene.buildIndex == nextScene)
        {
            if (nextScene < 9) nextScene ++;
            else nextScene = 6;
        }
        SceneManager.LoadScene (nextScene);
    }
}
