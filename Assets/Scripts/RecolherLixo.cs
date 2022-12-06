using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolherLixo : MonoBehaviour
{
    public static RecolherLixo acesso;

    //private Animator anim;

    bool mouseDentroDoObjeto;
    // Start is called before the first frame update
    void Start()
    {
        mouseDentroDoObjeto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseDentroDoObjeto == true)
        {
            if(Input.GetMouseButtonDown (0))
            {
                //anim = GetComponent<Animator>();
                //anim.SetBool("work", true);
                Destroy(gameObject, 0.3f);
            }
        }
    }

    void OnMouseEnter()
    {
        mouseDentroDoObjeto = true;
    }

    void OnMouseExit()
    {
        mouseDentroDoObjeto = false;
    }
}
