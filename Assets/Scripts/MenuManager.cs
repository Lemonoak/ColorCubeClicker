using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class MenuManager : MonoBehaviour {

    public static MenuManager instance;

    public TextMeshProUGUI Highscore1Text;
    public TextMeshProUGUI Highscore2Text;
    public TextMeshProUGUI Highscore3Text;
    public TextMeshProUGUI randomMenuText;

    public TextMeshProUGUI Highscore1TextTT;
    public TextMeshProUGUI Highscore2TextTT;
    public TextMeshProUGUI Highscore3TextTT;

    public TextMeshProUGUI Highscore1TextRE;
    public TextMeshProUGUI Highscore2TextRE;
    public TextMeshProUGUI Highscore3TextRE;

    public GameObject MainPanel;
    public GameObject HighscoreSelectPanel;
    public GameObject HighscorePanel;
    public GameObject HighscorePanelTT;
    public GameObject HighscorePanelRE;
    public GameObject SettingsPanel;
    public GameObject AreYouSurePanel;
    public GameObject InfoPanel;
    public GameObject GameSelectPanel;
    public GameObject InfoOriginalPanel;
    public GameObject InfoReversePanel;
    public GameObject InfoTimeTrialPanel;

    public GameObject SoundOnbutton;
    public GameObject SoundOffButton;
    public GameObject InfoButton;

    public TextMeshProUGUI GameNameText;
    public Color LerpedColor = Color.white;

    void Start ()
    {
        instance = this;
        SaveManager.instance.Save();
	}

	void Update ()
    {
        Highscore1Text.text = Preloadermanager.instance.highscore1.ToString();
        Highscore2Text.text = Preloadermanager.instance.highscore2.ToString();
        Highscore3Text.text = Preloadermanager.instance.highscore3.ToString();

        Highscore1TextTT.text = Preloadermanager.instance.highscore1TT.ToString();
        Highscore2TextTT.text = Preloadermanager.instance.highscore2TT.ToString();
        Highscore3TextTT.text = Preloadermanager.instance.highscore3TT.ToString();

        Highscore1TextRE.text = Preloadermanager.instance.highscore1RE.ToString();
        Highscore2TextRE.text = Preloadermanager.instance.highscore2RE.ToString();
        Highscore3TextRE.text = Preloadermanager.instance.highscore3RE.ToString();

        if (Preloadermanager.instance.soundOn)
        {
            SoundOffButton.SetActive(false);
            SoundOnbutton.SetActive(true);
        }
        else if (Preloadermanager.instance.soundOn == false)
        {
            SoundOffButton.SetActive(true);
            SoundOnbutton.SetActive(false);
        }

        if(randomMenuText.text == "_")
        {
            randomMenuText.text = "";
        }

        LerpedColor = Color.Lerp(Color.blue, Color.green, Mathf.PingPong(Time.time, 1));

        GameNameText.color = LerpedColor;

    }


    public void HighscoreSelectPanelOpen()
    {
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(true);
    }

    public void HighscoreTTPanelOpen()
    {
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(true);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(false);
    }

    public void HighscoreREPanelOpen()
    {
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(true);
        HighscoreSelectPanel.SetActive(false);
    }

    public void HighscorePanelOpen()
    {
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(true);
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(false);
    }

    public void SettingsPanelOpen()
    {
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(true);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(false);
    }

    public void Close()
    {
        MainPanel.SetActive(true);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(false);
    }

    public void CloseAreYouSure()
    {
        AreYouSurePanel.SetActive(false);
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(true);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(false);
    }
    public void OpenAreYouSure()
    {
        AreYouSurePanel.SetActive(true);
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(false);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(false);
    }

    public void OpenPlayMenu()
    {
        MainPanel.SetActive(false);
        HighscorePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GameSelectPanel.SetActive(true);
        HighscorePanelTT.SetActive(false);
        HighscorePanelRE.SetActive(false);
        HighscoreSelectPanel.SetActive(false);
    }

    public void Playgame()
    {
        SceneManager.LoadScene(2);
    }

    public void PlaytimeTrial()
    {
        SceneManager.LoadScene(4);
    }

    public void PlaygameReverse()
    {
        SceneManager.LoadScene(6);
    }

    public void OpenInfo()
    {
        SettingsPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void CloseInfo()
    {
        SettingsPanel.SetActive(true);
        InfoPanel.SetActive(false);
    }

    public void OpenOriginalInfo()
    {
        InfoOriginalPanel.SetActive(true);
        InfoReversePanel.SetActive(false);
        InfoTimeTrialPanel.SetActive(false);
        InfoPanel.SetActive(false);
    }
    public void OpenReverseInfo()
    {
        InfoOriginalPanel.SetActive(false);
        InfoReversePanel.SetActive(true);
        InfoTimeTrialPanel.SetActive(false);
        InfoPanel.SetActive(false);
    }
    public void OpenTimeTrialInfo()
    {
        InfoOriginalPanel.SetActive(false);
        InfoReversePanel.SetActive(false);
        InfoTimeTrialPanel.SetActive(true);
        InfoPanel.SetActive(false);
    }

    public void BackInfo()
    {
        InfoOriginalPanel.SetActive(false);
        InfoReversePanel.SetActive(false);
        InfoTimeTrialPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void TurnOffSound()
    {
        Preloadermanager.instance.soundOn = true;
        SaveManager.instance.Save();
    }
    public void TurnOnSound()
    {
        Preloadermanager.instance.soundOn = false;
        SaveManager.instance.Save();
    }
}
