using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySee : MonoBehaviour
{
    public Image spottedScreen;
    public Transform player;
    [SerializeField] GameObject spottedText;
    public GameObject pm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator fade()
    {
        //can't move
        pm.GetComponent<PlayerMove>().enabled = false;

        for (float i = 0; i <= 1.1f; i += 10f * Time.deltaTime)//fade in the spottedScreen imedge -Sixten
        {
            yield return new WaitForSeconds(0.01f);
            spottedScreen.color = new Color(spottedScreen.color.r, spottedScreen.color.g, spottedScreen.color.b, i);
        }

        spottedText.SetActive(true);

        player.position = new Vector2(-0.9f, -1.6f);//teleports the player to spawn -Sixten
        yield return new WaitForSeconds(2f);

        spottedText.SetActive(false);

        for (float i = 0.9f; i >= 0; i -= 10f * Time.deltaTime)//fade out the spottedScreen imedge -Sixten
        {
            yield return new WaitForSeconds(0.01f);
            spottedScreen.color = new Color(spottedScreen.color.r, spottedScreen.color.g, spottedScreen.color.b, i);
        }

        //can move again
        pm.GetComponent<PlayerMove>().enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))//when enemy sees player: start the respawn prosses -Sixten
        {
            print("Spotted");

            StartCoroutine(fade());
        }
    }
}
