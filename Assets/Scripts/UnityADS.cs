using UnityEngine;
using UnityEngine.Advertisements;

public class UnityADS : MonoBehaviour {

    public static UnityADS instance;

    public int losstimesforad;

    public int timesadPlayed;

    void Start ()
    {
        instance = this;
        losstimesforad = 0;
    }

    public void Update()
    {
        if(losstimesforad == 15)
        {
            ShowAd();
            losstimesforad = 0;
            timesadPlayed++;
        }
    }


    public void ShowAd()
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show();    
        }
        else
        {

        }
    }
    

}
