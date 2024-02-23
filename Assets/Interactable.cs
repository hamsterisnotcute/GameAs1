using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public GameObject UiObject;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            UiObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        UiObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
