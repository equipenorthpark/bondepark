using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;

    private Animator anim; 
    private Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // Cria método de movimento
    void Move()
    {
        // O Input serve para detectar teclas e definir valores para elas
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        // transform.position só funciona com Vector3
        // Time.deltaTime serve para definir velocidade e Speed controlaremos no Unity
        transform.position += movement * Time.deltaTime * Speed;

        // Quando estiver andando (para esquerda ou direita) o boleando "walk" será true, então ele executará as animações feitas
        if(Input.GetAxis("Horizontal") > 0)
        {
            anim.SetBool("walk", true);
            // eulerAngles nos permite rotacionar o objeto
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if(Input.GetAxis("Horizontal") < 0)
        {
            anim.SetBool("walk", true);
            // Aqui o valor do eixo x é 180 porque ele está virado para a esquerda
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        // Quando estiver parado o boleando "walk" será false
        if(Input.GetAxis("Horizontal") == 0)
        {
            anim.SetBool("walk", false);
        }



    }
}
