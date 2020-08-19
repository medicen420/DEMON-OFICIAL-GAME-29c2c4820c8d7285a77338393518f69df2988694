using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{
    public Animator anim;
    public Button btn;
    //Vamos a mandar llamar al animator de nuestro jefe enemigo
    

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
        Button buton = btn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void TaskOnClick()
    {
        Debug.Log("Hola");
        anim.SetBool("CLOSE", true);
       
    }

   
}
