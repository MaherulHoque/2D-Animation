using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animController;

    // Start is called before the first frame update
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animController.SetBool("Swing", true);
        } else if (Input.GetMouseButtonUp(0))
        {
            animController.SetBool("Swing", false);
        }

        float H = Input.GetAxis("Horizontal");

        animController.SetFloat("Walk", H);
    }
}
