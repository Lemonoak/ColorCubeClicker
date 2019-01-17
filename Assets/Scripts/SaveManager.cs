using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveManager : MonoBehaviour {

    public static SaveManager instance;

    
    /*private void Awake()
    {
        Load();
    }
    */

    /*public void OnApplicationQuit()
    {
        Save();
    }
    */
    public void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            Save();
        }

    }

    void Start ()
    {
        Load();

        instance = this;
	}
	

    public void Save()
    {
        BinaryFormatter binary = new BinaryFormatter();
        //add a / to the filename if it doesnt work
        FileStream fStream = File.Create(Application.persistentDataPath + "/SaveData.dat");

        SaveData saver = new SaveData();
#region everything i save
        //everything i save
        saver.highscore1 = Preloadermanager.instance.highscore1;
        saver.highscore2 = Preloadermanager.instance.highscore2;
        saver.highscore3 = Preloadermanager.instance.highscore3;
        saver.highscore1TT = Preloadermanager.instance.highscore1TT;
        saver.highscore2TT = Preloadermanager.instance.highscore2TT;
        saver.highscore3TT = Preloadermanager.instance.highscore3TT;
        saver.highscore1RE = Preloadermanager.instance.highscore1RE;
        saver.highscore2RE = Preloadermanager.instance.highscore2RE;
        saver.highscore3RE = Preloadermanager.instance.highscore3RE;
        saver.soundonoff = Preloadermanager.instance.soundOn;

        saver.lossuntiladint = UnityADS.instance.losstimesforad;
        saver.adsplayed = UnityADS.instance.timesadPlayed;

        #endregion


        binary.Serialize(fStream, saver);
        fStream.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveData.dat"))
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream fStream = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);
            SaveData saver = (SaveData)binary.Deserialize(fStream);
            fStream.Close();
            #region everything i load
             //everything i load
            Preloadermanager.instance.highscore1 = saver.highscore1;
            Preloadermanager.instance.highscore2 = saver.highscore2;
            Preloadermanager.instance.highscore3 = saver.highscore3;
            Preloadermanager.instance.highscore1TT = saver.highscore1TT;
            Preloadermanager.instance.highscore2TT = saver.highscore2TT;
            Preloadermanager.instance.highscore3TT = saver.highscore3TT;
            Preloadermanager.instance.highscore1RE = saver.highscore1RE;
            Preloadermanager.instance.highscore2RE = saver.highscore2RE;
            Preloadermanager.instance.highscore3RE = saver.highscore3RE;
            Preloadermanager.instance.soundOn = saver.soundonoff;

            UnityADS.instance.losstimesforad = saver.lossuntiladint;
            UnityADS.instance.timesadPlayed = saver.adsplayed;
            #endregion
        }


    }

    public void Delete()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveData.dat"))
        {
            File.Delete(Application.persistentDataPath + "/SaveData.dat");
            RefreshEditorProjectWindow();
            Application.Quit();
        }

    }

    void RefreshEditorProjectWindow()
    {
        #if UNITY_EDITOR
        UnityEditor.AssetDatabase.Refresh();
        #endif
    }

    [Serializable]
    class SaveData
    {

        public int highscore1;
        public int highscore2;
        public int highscore3;
        public int highscore1TT;
        public int highscore2TT;
        public int highscore3TT;
        public int highscore1RE;
        public int highscore2RE;
        public int highscore3RE;
        public bool soundonoff;

        public int lossuntiladint;
        public int adsplayed;
    }

}