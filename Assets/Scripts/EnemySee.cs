using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySee : MonoBehaviour
{
    public Image spottedScreen;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        print("start");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator fade()
    {
        for (float i = 0; i <= 1.1f; i += 10f * Time.deltaTime)
        {
            yield return new WaitForSeconds(0.01f);
            spottedScreen.color = new Color(spottedScreen.color.r, spottedScreen.color.g, spottedScreen.color.b, i);
        }

        player.position = new Vector2(0, 0);
        yield return new WaitForSeconds(2f);

        for (float i = 0.9f; i >= 0; i -= 10f * Time.deltaTime)
        {
            yield return new WaitForSeconds(0.01f);
            spottedScreen.color = new Color(spottedScreen.color.r, spottedScreen.color.g, spottedScreen.color.b, i);
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            print("Spotted");
            StartCoroutine(fade());
        }
    }
}
