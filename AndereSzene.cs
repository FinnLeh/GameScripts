using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktuellesJahrTimeLine : MonoBehaviour {

    private Text aktuellesJahr;

    private void Awake()
    {
        aktuellesJahr = GetComponent<Text>();
    }

    private void Update()
    {
        if (AktuellesJahrHauptSpiel.JahrBC >= 1)
        {
            aktuellesJahr.text = AktuellesJahrHauptSpiel.JahrBC.ToString() + " before Christ";
        }
        else
        {
            aktuellesJahr.text = AktuellesJahrHauptSpiel.JahrAD.ToString() + " anno Domini";
        }
    }
}

// Das ist dann die andere Szene, in der die Zahl aus dem YearScript.cs angezeigt werden soll.
// Der Retry-Button in dieser Szene hat als Skript nur, das die Szene davor wieder geladen werden soll.
