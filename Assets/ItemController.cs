using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject FloatText;
    public Transform Collider;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(FloatText != null)
            {
                Instantiate(FloatText, Collider.position, Collider.rotation);
            }
            Debug.Log("Player can now pick up this item!");
        }
    }
}
