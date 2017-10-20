using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktuellesJahrHauptSpiel : MonoBehaviour {

    public static int JahrBC = 0;
    public static int JahrAD = 0;
    private Text aktuellesJahr;
    public bool year = false;

    private void Awake()
    {
        aktuellesJahr = GetComponent<Text>();
    }

    void Start ()
    {
        startYear();
        aktuellesJahr.text = JahrBC.ToString() + " before Christ";
	}

    //Mit void startYear() habe ich versucht, dass die Zahl nur einmal am Anfang verändert wird, hat aber nichts gebracht, kann also eigentlich gelöscht werden.
    void startYear()
    {
        if (!year)
        {
            JahrBC = 753;
            year = true;
        }
    }

    //Diese Funktionen werden aufgerufen, wenn das was nötig ist angeklickt wird.
    void increaseYear(int click)
    {
        if (JahrBC >= 1)
        {
            JahrBC -= click;
            aktuellesJahr.text = JahrBC.ToString() + " before Christ";
        }
        else
        {
            JahrAD += click;
            aktuellesJahr.text = JahrAD.ToString() + " anno Domini";
        }
    }
}

// In einer anderen Szene werden diese Zahlen ebenfalls ausgegeben, also sozusagen im "GameOver"-Bereich.
// Sobald man vom "GameOver"-Bereich zurück in diese Szene kommt, wird 'JahrBC' aber wieder 753. Diese soll aber das bleiben, was sie am Ende dieser Szene war.
