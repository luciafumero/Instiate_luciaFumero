using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputExample : MonoBehaviour
{

    public void ActtionButtonSouth(InputAction.CallbackContext callback)
    {
      
        Debug.Log("Presionando boton sur");
    }  
        //empezar
        //callback.started

        //cancela
        //callback.canceled

        //callback.duration
}
