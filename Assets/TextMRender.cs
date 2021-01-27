using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMRender : MonoBehaviour
{
    public Renderer TextRendered;

    // Start is called before the first frame update
    private void Start()
        {
            
            TextRendered.GetComponent<Renderer>().enabled = false;
        }
}
