using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktuellesJahrHauptSpiel : MonoBehaviour {

    private Text aktuellesJahr;

    private void Awake()
    {
        aktuellesJahr = GetComponent<Text>();
    }

    private void Update()
    {
        if (AktuellesJahrSystemInteger.JahrBC >= 1)
        {
            aktuellesJahr.text = AktuellesJahrSystemInteger.JahrBC.ToString() + " before Christ";
        }
        else
        {
            aktuellesJahr.text = AktuellesJahrSystemInteger.JahrAD.ToString() + " anno Domini";
        }
    }
}
