using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolherLixo : MonoBehaviour
{
    //private Animator anim;

    public static RecolherLixo acesso;

    public bool mouseDentroDoObjeto;
    // Start is called before the first frame update
    void Start()
    {
        acesso = this;
        mouseDentroDoObjeto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseDentroDoObjeto == true)
        {
            if(Input.GetMouseButtonDown (0))
            {
                
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
