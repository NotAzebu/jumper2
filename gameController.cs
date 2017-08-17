using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

    public AudioSource backgroundMusic;
    public GameObject pauseMenuUI;

	// Use this for initialization
	void Start ()
    {
        pauseMenuUI.gameObject.SetActive (false);
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    void TogglePause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            backgroundMusic.Pause();
            toggleMenu();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            backgroundMusic.Play();
            toggleMenu();
        }
    }
    void toggleMenu()
    {
        if (Time.timeScale == 0)
        {
            pauseMenuUI.gameObject.SetActive(true);
        }
        else if (Time.timeScale == 1)
        {
            pauseMenuUI.gameObject.SetActive (false);
            //Debug.Log("pause menu off");
        }
    }
}
