using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class codePanel : MonoBehaviour
{
    //gjord av max
    public int keyPadCode;

    [SerializeField]
    TextMeshProUGUI codeText;

    string codeTextValue = ("");

    private void Start()
    {
        keyPadCode = Random.Range(1000, 9999);//gör en randomKod till safe
        print("test");
    }
    // Update is called once per frame
    void Update()
    {
        
        
        codeText.text = codeTextValue;

        if (codeTextValue == keyPadCode.ToString())//om du klickar in rätt kod så öppnar safe
        {
            safe.isKeyPadOpen = true;
        }
        if (codeTextValue.Length >= 4)//när du skrivit 4 siffror så raderar den siffrorna så du kan försöka igen
        {
            codeTextValue = ("");
        }
    }

    public void AddDigit(string digit)//när du klickar ökar codeTextValue.length
    {
        codeTextValue += digit;
    }


}
