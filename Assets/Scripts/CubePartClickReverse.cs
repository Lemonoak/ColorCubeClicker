using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CubePartClickReverse : MonoBehaviour
{

    public static CubePartClickReverse instance;

    public int score;

    public int colorvalue;
    public int colortextvalue;

    public int cubevalue;
    public float standardtimer;
    public float timer;

    public float totalclicktimer;

    public TextMeshProUGUI timertext;
    public TextMeshProUGUI Scoretext;

    public TextMeshProUGUI ColorTextRed;
    public TextMeshProUGUI ColorTextGreen;
    public TextMeshProUGUI ColorTextBlue;
    public TextMeshProUGUI ColorTextYellow;
    public TextMeshProUGUI ColorTextWhite;
    public GameObject Colortextred;
    public GameObject Colortextgreen;
    public GameObject Colortextblue;
    public GameObject Colortextyellow;
    public GameObject Colortextwhite;

    public GameObject Leftred;
    public GameObject Leftblue;
    public GameObject Leftgreen;

    public GameObject Rightred;
    public GameObject Rightblue;
    public GameObject Rightgreen;

    public GameObject Topred;
    public GameObject Topblue;
    public GameObject Topgreen;


    void Start()
    {
        instance = this;
        score = 0;
        randomizestarttextcolor();
        randomizecolortextvalue();
        cubevalue = 1;
        standardtimer = 5.1f;
        timer = standardtimer;
    }

    void Update()
    {
        Scoretext.text = score.ToString();
        SetColorTextrandom();
        SetTextRandom();
        SetCubeColors();
        timertext.maxVisibleCharacters = 3;
        timertext.text = timer.ToString();

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Preloadermanager.instance.newhighscore = score;
            Preloadermanager.instance.endscore = score;
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            SceneManager.LoadScene(3);
        }

        #region scoretimerchanger
        if (score >= 10)
        {
            standardtimer = 4.8f;
        }
        if (score >= 20)
        {
            standardtimer = 4.5f;
        }
        if (score >= 30)
        {
            standardtimer = 4.2f;
        }
        if (score >= 40)
        {
            standardtimer = 3.9f;
        }
        if (score >= 50)
        {
            standardtimer = 3.6f;
        }
        if (score >= 60)
        {
            standardtimer = 3.3f;
        }
        if (score >= 70)
        {
            standardtimer = 3f;
        }
        if (score >= 80)
        {
            standardtimer = 2.7f;
        }
        if (score >= 90)
        {
            standardtimer = 2.4f;
        }
        if (score >= 100)
        {
            standardtimer = 2f;
        }
        /*if(score >= 500)
        {
            standardtimer = 1f;
        }
        */
        #endregion

    }

    void randomizetextcolor()
    {
        colorvalue = Random.Range(1, 4);
    }
    void randomizecolortextvalue()
    {
        colortextvalue = Random.Range(1, 7);
    }
    void randomizecubevalue()
    {
        cubevalue = Random.Range(1, 7);
    }

    void SetColorTextrandom()
    {
        if (colorvalue == 1)
        {
            ColorTextGreen.color = Color.red;
            ColorTextBlue.color = Color.red;
            ColorTextRed.color = Color.red;
        }
        if (colorvalue == 2)
        {
            ColorTextGreen.color = Color.green;
            ColorTextBlue.color = Color.green;
            ColorTextRed.color = Color.green;
        }
        if (colorvalue == 3)
        {
            ColorTextGreen.color = Color.blue;
            ColorTextBlue.color = Color.blue;
            ColorTextRed.color = Color.blue;
        }
        // Onödiga egentligen...
        if (colorvalue == 4)
        {
            ColorTextGreen.color = Color.red;
            ColorTextBlue.color = Color.red;
            ColorTextRed.color = Color.red;
        }
        if (colorvalue == 5)
        {
            ColorTextGreen.color = Color.green;
            ColorTextBlue.color = Color.green;
            ColorTextRed.color = Color.green;
        }
        if (colorvalue == 6)
        {
            ColorTextGreen.color = Color.blue;
            ColorTextBlue.color = Color.blue;
            ColorTextRed.color = Color.blue;
        }
    }
    void SetTextRandom()
    {
        if (colortextvalue == 1)
        {
            Colortextgreen.SetActive(true);
            Colortextblue.SetActive(false);
            Colortextred.SetActive(false);
        }
        if (colortextvalue == 2)
        {
            Colortextgreen.SetActive(false);
            Colortextblue.SetActive(true);
            Colortextred.SetActive(false);
        }
        if (colortextvalue == 3)
        {
            Colortextgreen.SetActive(false);
            Colortextblue.SetActive(false);
            Colortextred.SetActive(true);
        }
        // Onödiga egentligen...
        if (colortextvalue == 4)
        {
            Colortextgreen.SetActive(true);
            Colortextblue.SetActive(false);
            Colortextred.SetActive(false);
        }
        if (colortextvalue == 5)
        {
            Colortextgreen.SetActive(false);
            Colortextblue.SetActive(true);
            Colortextred.SetActive(false);
        }
        if (colortextvalue == 6)
        {
            Colortextgreen.SetActive(false);
            Colortextblue.SetActive(false);
            Colortextred.SetActive(true);
        }
    }
    void SetCubeColors()
    {
        if (colorvalue == 1)
        {
            Leftgreen.SetActive(true);
            Leftblue.SetActive(false);
            Leftred.SetActive(false);

            Rightblue.SetActive(true);
            Rightred.SetActive(false);
            Rightgreen.SetActive(false);

            Topred.SetActive(true);
            Topgreen.SetActive(false);
            Topblue.SetActive(false);
        }
        if (colorvalue == 2)
        {
            Leftgreen.SetActive(false);
            Leftblue.SetActive(true);
            Leftred.SetActive(false);

            Rightblue.SetActive(false);
            Rightred.SetActive(false);
            Rightgreen.SetActive(true);

            Topred.SetActive(true);
            Topgreen.SetActive(false);
            Topblue.SetActive(false);
        }
        if (colorvalue == 3)
        {
            Leftgreen.SetActive(false);
            Leftblue.SetActive(false);
            Leftred.SetActive(true);

            Rightblue.SetActive(true);
            Rightred.SetActive(false);
            Rightgreen.SetActive(false);

            Topred.SetActive(false);
            Topgreen.SetActive(true);
            Topblue.SetActive(false);
        }
        if (colorvalue == 4)
        {
            Leftgreen.SetActive(false);
            Leftblue.SetActive(true);
            Leftred.SetActive(false);

            Rightblue.SetActive(false);
            Rightred.SetActive(true);
            Rightgreen.SetActive(false);

            Topred.SetActive(false);
            Topgreen.SetActive(true);
            Topblue.SetActive(false);
        }
        if (colorvalue == 5)
        {
            Leftgreen.SetActive(true);
            Leftblue.SetActive(false);
            Leftred.SetActive(false);

            Rightblue.SetActive(false);
            Rightred.SetActive(true);
            Rightgreen.SetActive(false);

            Topred.SetActive(false);
            Topgreen.SetActive(false);
            Topblue.SetActive(true);
        }
        if (colorvalue == 6)
        {
            Leftgreen.SetActive(false);
            Leftblue.SetActive(false);
            Leftred.SetActive(true);

            Rightblue.SetActive(false);
            Rightred.SetActive(false);
            Rightgreen.SetActive(true);

            Topred.SetActive(false);
            Topgreen.SetActive(false);
            Topblue.SetActive(true);
        }

    }


    public void cubeclickleft()
    {
        if (Leftgreen.active == true && colorvalue == 2)
        {
            // Randomizes the cubes side color
            randomizecubevalue();
            // Randomizes the color that the text says
            randomizecolortextvalue();
            // Randomizes the color that the text is
            randomizetextcolor();
            // Does nothing (was meant to add the fastest click you've made to scoreboard but never implemented
            Averagetime();
            // Sets the timer to the standard value (depends on how much points you have)
            timer = standardtimer;
            // Plays a sound so that the player knows he/she pressed the right side
            Preloadermanager.instance.Dong.Play();
            // Adds a point to the score
            score++;
        }
        else if (Leftgreen.active == true && colorvalue != 2)
        {
            // Adds 1 to the int that plays ads after it goes to 15
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            // Adds the last score you had to check if its higher then any of your last 3 highscores
            Preloadermanager.instance.newhighscoreRE = score;
            // Sets the score to show in the "you lost" scene
            Preloadermanager.instance.endscoreRE = score;
            // Loads the "you lost" scene
            SceneManager.LoadScene(7);
        }
        if (Leftred.active == true && colorvalue == 1)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Leftred.active == true && colorvalue != 1)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
        if (Leftblue.active == true && colorvalue == 3)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Leftblue.active == true && colorvalue != 3)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
    }
    public void cubeclickright()
    {
        if (Rightgreen.active == true && colorvalue == 2)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Rightgreen.active == true && colorvalue != 2)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
        if (Rightred.active == true && colorvalue == 1)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Rightred.active == true && colorvalue != 1)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
        if (Rightblue.active == true && colorvalue == 3)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Rightblue.active == true && colorvalue != 3)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
    }
    public void cubeclicktop()
    {
        if (Topgreen.active == true && colorvalue == 2)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Topgreen.active == true && colorvalue != 2)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
        if (Topred.active == true && colorvalue == 1)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Topred.active == true && colorvalue != 1)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
        if (Topblue.active == true && colorvalue == 3)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            timer = standardtimer;
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Topblue.active == true && colorvalue != 3)
        {
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreRE = score;
            Preloadermanager.instance.endscoreRE = score;
            SceneManager.LoadScene(7);
        }
    }

    public void randomizestarttextcolor()
    {
        colorvalue = Random.Range(1, 4);
    }

    public void Averagetime()
    {
        totalclicktimer += timer;
    }

}