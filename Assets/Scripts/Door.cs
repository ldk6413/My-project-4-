using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool fcollision = false;
    


    public GameObject goTarget;
    public GameObject goGamecrear;
    // Start is called before the first frame update
    void Start()
    {
        goGamecrear.SetActive(false);
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        //if (collision.gameObject.name == "LBlock")
        if (collision.gameObject.name == goTarget.name)
        {
            GameObject _goTarget = GameObject.Find(collision.gameObject.name);
            if (_goTarget != null)
            {
                _goTarget.SetActive(false);
                goGamecrear.SetActive(true);
                Time.timeScale = 0;
            }

        }
    }
}
