using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LostScreenThree : MonoBehaviour
{

    public static LostScreenThree instance;

    public GameObject highscoretextRE;
    public TextMeshProUGUI endscoretextRE;

    private void Start()
    {
        instance = this;
    }

    public void Update()
    {
        endscoretextRE.text = Preloadermanager.instance.endscoreRE.ToString();
    }


    public void ExitButton()
    {
        SaveManager.instance.Save();
        SceneManager.LoadScene(1);
        Preloadermanager.instance.endscoreRE = 0;
    }
}
