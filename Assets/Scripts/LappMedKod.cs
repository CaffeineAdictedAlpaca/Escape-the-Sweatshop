using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LappMedKod : Interact
{
    //gjord av max
   
    [SerializeField]
    TextMeshProUGUI safeKoden;
    public codePanel safeCode;
    
    
    public override void _Interact()//n�r du interactar s� ska texten p� lappen visa random koden
    {
        safeKoden.text = safeCode.safeCode.ToString();
    }
}
