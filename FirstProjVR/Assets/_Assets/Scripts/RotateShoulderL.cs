using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateShoulderL : MonoBehaviour
{
       public float time =5.0f;
     public float timeBack;
   public float temporizador;
      public float RotationVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
     timeBack= time;
    }

    // Update is called once per frame
    void Update()
    {   
     
        temporizador +=Time.deltaTime;
            if(temporizador <=time){
              RotateHandForward();
              
          
            }    
            else{
                RotateHandBack();
            }
   
    }

    void RotateHandForward(){
            transform.Rotate(-Vector3.forward *RotationVelocity*Time.deltaTime);
           
    }

     void RotateHandBack(){
      
        timeBack = timeBack-Time.deltaTime;
        transform.Rotate(Vector3.forward *RotationVelocity*Time.deltaTime);
          if(timeBack <= 0.0f)
        {
            temporizador = 0.0f;
            timeBack=time;
            Debug.Log("aqio");
        }
    }
}
