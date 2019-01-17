using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CubePartClickTimeTrial : MonoBehaviour
{

    public static CubePartClickTimeTrial instance;

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
    public GameObject Colortextred;
    public GameObject Colortextgreen;
    public GameObject Colortextblue;

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
        standardtimer = 60.0f;
        timer = standardtimer;
    }

    void Update()
    {
        Scoretext.text = score.ToString();
        SetColorTextrandom();
        SetTextRandom();
        SetCubeColors();

        if(timer < 10f)
        {
            timertext.maxVisibleCharacters = 3;
        }
        else if(timer > 10f)
        {
            timertext.maxVisibleCharacters = 2;
        }

        timertext.text = timer.ToString();

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            SceneManager.LoadScene(5);
        }

    }

    void randomizetextcolor()
    {
        colorvalue = Random.Range(1, 7);
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
        if (Leftgreen.active == true && Colortextgreen.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Leftgreen.active == true && Colortextgreen.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
        if (Leftred.active == true && Colortextred.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Leftred.active == true && Colortextred.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
        if (Leftblue.active == true && Colortextblue.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Leftblue.active == true && Colortextblue.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
    }
    public void cubeclickright()
    {
        if (Rightgreen.active == true && Colortextgreen.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Rightgreen.active == true && Colortextgreen.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
        if (Rightred.active == true && Colortextred.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Rightred.active == true && Colortextred.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
        if (Rightblue.active == true && Colortextblue.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Rightblue.active == true && Colortextblue.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
    }
    public void cubeclicktop()
    {
        if (Topgreen.active == true && Colortextgreen.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Topgreen.active == true && Colortextgreen.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
        if (Topred.active == true && Colortextred.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Topred.active == true && Colortextred.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
        if (Topblue.active == true && Colortextblue.active == true)
        {
            randomizecubevalue();
            randomizecolortextvalue();
            randomizetextcolor();
            Averagetime();
            Preloadermanager.instance.Dong.Play();
            score++;
        }
        else if (Topblue.active == true && Colortextblue.active == false)
        {
            if (score > 0)
            {
                score--;
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            else if (score == 0)
            {
                Preloadermanager.instance.Wrong.Play();
                randomizecubevalue();
                randomizecolortextvalue();
                randomizetextcolor();
            }
            /*
            UnityADS.instance.losstimesforad = UnityADS.instance.losstimesforad + 1;
            Preloadermanager.instance.newhighscoreTT = score;
            Preloadermanager.instance.endscoreTT = score;
            SceneManager.LoadScene(5);
            */
        }
    }

    public void randomizestarttextcolor()
    {
        colorvalue = Random.Range(1, 4);
    }

    public void Averagetime()
    {
        
    }

}