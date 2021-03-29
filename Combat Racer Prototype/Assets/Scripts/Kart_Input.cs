using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Kart_Input : MonoBehaviour
{
   
// Testing GitHub Commit!
  [SerializeField]private float kartSpeed, kartMaxSpeed; 
  [SerializeField]protected float accleration;
  [SerializeField]private float turnSpeed; 
  [SerializeField]private Rigidbody kartRb;
  [SerializeField]private bool canMove; 
  [SerializeField]
    private void Update()
    {
        if (Input.GetButton("Accelerate"))  
        {
            Kart_Accelrate();
        }
        Kart_Steer(); 
    }

    private void Kart_Accelrate()  
    {
        
        Debug.Log("Kart Acclerating");
            if (kartSpeed <= kartMaxSpeed)
            {
               kartSpeed = accleration * Time.deltaTime;
            }
        
        transform.Translate(0f, 0f, kartSpeed);
    }

    private void Kart_Steer()
    { 

        transform.Translate(Input.GetAxis("Horizontal") * turnSpeed, 0f, 0f);
    }

}

