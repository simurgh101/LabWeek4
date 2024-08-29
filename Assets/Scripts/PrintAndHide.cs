using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 4;
    public Renderer rend;
    private int rnd;
    //public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        rnd = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag=="Red" && i==100)
        {
            gameObject.SetActive(false);
        } else if (gameObject.tag=="Blue" && i==rnd) {
            rend.enabled = false;
        }
        Debug.Log(gameObject.name+":"+ i++);
    }
}