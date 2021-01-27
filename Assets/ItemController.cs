using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public Transform Collider;
    public GameObject Textbool;
    private TextMRender bool_script;
    

    private void Start()
    {
        bool_script = Textbool.GetComponent<TextMRender>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            bool_script.TextRendered.GetComponent<Renderer>().enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bool_script.TextRendered.GetComponent<Renderer>().enabled = false;
    }
}
