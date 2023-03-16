using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class OculusHands : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    public InputActionReference gripReference, triggerReferece;
    void Start()
    {
        anim = GetComponent<Animator>();
        gripReference.action.started +=GripPressed;
        gripReference.action.canceled +=GripCenceled;

        triggerReferece.action.started +=TriggerPressed;
        triggerReferece.action.canceled +=TriggerCancelled;
    }

    private void OnDestroy() 
    {
         gripReference.action.started -=GripPressed;
        gripReference.action.canceled -=GripCenceled;

        triggerReferece.action.started -=TriggerPressed;
        triggerReferece.action.canceled -=TriggerCancelled;    
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void GripPressed(InputAction.CallbackContext junk)
    {
        Debug.Log("Gripped Preseed");
        anim.SetBool("GripPressed",true);
    }

      void GripCenceled(InputAction.CallbackContext junk)
    {
        Debug.Log("Gripped cancelled");
        anim.SetBool("GripPressed",false);
    }

     void TriggerPressed(InputAction.CallbackContext junk)
    {
        Debug.Log("Trigger Preseed");
        anim.SetBool("TriggerPressed",true);
    }

      void TriggerCancelled(InputAction.CallbackContext junk)
    {
        Debug.Log("Trigger cancelled");
        anim.SetBool("TriggerPressed",false);
    }
}
