using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LostScreen : MonoBehaviour {

    public static LostScreen instance;

    public GameObject highscoretext;
    public TextMeshProUGUI endscoretext;

    private void Start()
    {
        instance = this;
    }

    public void Update()
    {
        endscoretext.text = Preloadermanager.instance.endscore.ToString();
    }


    public void ExitButton()
    {
        SaveManager.instance.Save();
        SceneManager.LoadScene(1);
        Preloadermanager.instance.endscore = 0;
    }
}
