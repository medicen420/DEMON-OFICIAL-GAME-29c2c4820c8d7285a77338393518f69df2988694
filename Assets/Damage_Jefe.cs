using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Jefe : MonoBehaviour
{
    public int daño;
    public JefeLife jflife;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "JEFE")
        {
            jflife.life -= daño;
            Debug.Log("impactamos contra el jefe");
        }
    }
}
