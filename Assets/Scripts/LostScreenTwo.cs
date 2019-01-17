using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LostScreenTwo : MonoBehaviour
{
    public static LostScreenTwo instance;

    public GameObject highscoretextTT;
    public TextMeshProUGUI endscoretextTT;

    private void Start()
    {
        instance = this;
    }

    public void Update()
    {
        endscoretextTT.text = Preloadermanager.instance.endscoreTT.ToString();
    }


    public void ExitButton()
    {
        SaveManager.instance.Save();
        SceneManager.LoadScene(1);
        Preloadermanager.instance.endscore = 0;
    }
}
