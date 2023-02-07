using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Key : MonoBehaviour
{
    public GameObject goTarget;
    public static int Count = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == goTarget.name)
        {
            GameObject _goTarget = GameObject.Find(collision.gameObject.name);
            if (_goTarget != null)
            {
                Count++;
                Destroy(this.gameObject);
            }           
        }
    }
}
