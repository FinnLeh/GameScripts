using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktuellesJahrSystemInteger : MonoBehaviour {

    public static int JahrBC = 0;
    public static int JahrAD = 0;
    public bool year = false;
    public static AktuellesJahrHauptSpiel instance;
    public GameObject Aktuell_Jahr;

    private void Awake()
    {
        Aktuell_Jahr = GameObject.Find("AktuellesJahrRoot");
        DontDestroyOnLoad(Aktuell_Jahr);
    }

    void Start()
    {
        startYear();
    }

    void startYear()
    {
        if (!year)
        {
            JahrBC = 753;
            year = true;
        }
    }

    void increaseYear(int click)
    {
        if (JahrBC >= 1)
        {
            JahrBC -= click;
        }
        else
        {
            JahrAD += click;
        }
    }
}
