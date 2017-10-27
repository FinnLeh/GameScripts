using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HauptText : MonoBehaviour
{ 
    private Text textHaupt;
    public static bool start = false;
    public static bool loseFight = false;
    public static bool winFight = false;

    private void Awake()
    {
        textHaupt = GetComponent<Text>();
    }

    void card1()
    {
        if (SpezialLoadCard.card1)
        {
            textHaupt.text = "Der Senat will eure Macht beschränken!";
        }
    }

    void card2()
    {
        if (SpezialLoadCard.card2)
        {
            textHaupt.text = "Dieses Jahr hatten wir enorme Zolleinnahmen durch unsere Händler!";
        }
    }

    void card3()
    {
        if (SpezialLoadCard.card3)
        {
            textHaupt.text = "Wir haben unglaubliche Steuerüberschüsse!";
        }
    }

    void card4()
    {
        if (SpezialLoadCard.card4)
        {
            textHaupt.text = "Wir brauchen ein neues Forum!";
        }
    }

    void card5()
    {
        if (SpezialLoadCard.card5)
        {
            textHaupt.text = "Unsere Provinz Britannia wird geplündert!";
        }
    }
    
    private void Update()
    {
        card1();
        card2();
        card3();
        card4();
        card5();
    }
}
