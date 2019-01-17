using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Preloadermanager : MonoBehaviour {

    public static Preloadermanager instance;

    public int highscore1;
    public int highscore2;
    public int highscore3;
    public int newhighscore;
    public int endscore;

    public int highscore1TT;
    public int highscore2TT;
    public int highscore3TT;
    public int newhighscoreTT;
    public int endscoreTT;

    public int highscore1RE;
    public int highscore2RE;
    public int highscore3RE;
    public int newhighscoreRE;
    public int endscoreRE;

    public bool soundOn;

    public AudioSource Dong;
    public AudioSource Wrong;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
    }


    public void Update()
    {
        SetNewHighscore();
        SetNewHighscoreTimeTrial();
        SetNewHighscoreReverse();

        if (newhighscore > highscore1 || newhighscore > highscore2 || newhighscore > highscore3)
        {
            if(LostScreen.instance.highscoretext != null)
            {
                LostScreen.instance.highscoretext.SetActive(true);
            }

        }

        if (newhighscoreTT > highscore1TT || newhighscoreTT > highscore2TT || newhighscoreTT > highscore3TT)
        {
            if (LostScreenTwo.instance.highscoretextTT != null)
            {
                LostScreenTwo.instance.highscoretextTT.SetActive(true);
            }

        }

        if (newhighscoreRE > highscore1RE || newhighscoreRE > highscore2RE || newhighscoreRE > highscore3RE)
        {
            if (LostScreenThree.instance.highscoretextRE != null)
            {
                LostScreenThree.instance.highscoretextRE.SetActive(true);
            }

        }


        if (soundOn)
        {
            Dong.volume = 1;
            Wrong.volume = 0.3f;
        }
        else if (soundOn == false)
        {
            Dong.volume = 0;
            Wrong.volume = 0;
        }

    }


    public void SetNewHighscore()
    {
        if(newhighscore > highscore1)
        {
            highscore3 = highscore2;
            highscore2 = highscore1;
            highscore1 = newhighscore;
        }
        else if(newhighscore > highscore2 && newhighscore < highscore1)
        {
            highscore3 = highscore2;
            highscore2 = newhighscore;
        }
        else if(newhighscore > highscore3 && newhighscore < highscore1 && newhighscore < highscore2)
        {
            highscore3 = newhighscore;
        }
    }

    public void SetNewHighscoreTimeTrial()
    {
        if (newhighscoreTT > highscore1TT)
        {
            highscore3TT = highscore2TT;
            highscore2TT = highscore1TT;
            highscore1TT = newhighscoreTT;
        }
        else if (newhighscoreTT > highscore2TT && newhighscoreTT < highscore1TT)
        {
            highscore3TT = highscore2TT;
            highscore2TT = newhighscoreTT;
        }
        else if (newhighscoreTT > highscore3TT && newhighscoreTT < highscore1TT && newhighscoreTT < highscore2TT)
        {
            highscore3TT = newhighscoreTT;
        }
    }

    public void SetNewHighscoreReverse()
    {
        if (newhighscoreRE > highscore1RE)
        {
            highscore3RE = highscore2RE;
            highscore2RE = highscore1RE;
            highscore1RE = newhighscoreRE;
        }
        else if (newhighscoreRE > highscore2RE && newhighscoreRE < highscore1RE)
        {
            highscore3RE = highscore2RE;
            highscore2RE = newhighscoreRE;
        }
        else if (newhighscoreRE > highscore3RE && newhighscoreRE < highscore1RE && newhighscoreRE < highscore2RE)
        {
            highscore3RE = newhighscoreRE;
        }
    }

    private void Start()
    {
        instance = this;
        soundOn = true;
        Screen.fullScreen = true;
    }

}
