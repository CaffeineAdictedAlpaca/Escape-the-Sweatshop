using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTP : MonoBehaviour
{
    public Image blackScreen;
    [SerializeField] Transform endTP;
    [SerializeField] Transform player;
    IEnumerator TP()
    {
        for (float i = 0; i <= 1.1f; i += 10f * Time.deltaTime)//fade in the black screen -Sixten
        {
            yield return new WaitForSeconds(0.01f);
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, i);
        }

        player.position = endTP.position;//teleports the player to end -Sixten
        yield return new WaitForSeconds(2.5f);

        for (float i = 0.9f; i >= 0; i -= 10f * Time.deltaTime)//fade out the black screen -Sixten
        {
            yield return new WaitForSeconds(0.01f);
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, i);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))//if the player enters the end tp hitbox, start the teleport funktion -Sixten
        {
            StartCoroutine(TP());
        }

    }
}
