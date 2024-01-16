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
    
    
    public override void _Interact()//när du interactar så ska texten på lappen visa random koden
    {
        safeKoden.text = safeCode.safeCode.ToString();
    }
}
