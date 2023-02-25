
using UnityEngine;
using System.Collections;

public class tetrisBlock : MonoBehaviour {
    //Ininitialise variables
    public GameObject block;
    private float time = 3.0f;
    //public bool vertical = false;

    void Start(){
    //Give variables values

    }

    void Update(){
        //Processes/Instructions
        time -= Time.deltaTime;

        if (Input.GetKey("p") && time <= 0f){
            Rotate();
        }

        if (Input.GetKey("a")){
            this.transform.Translate(-0.01f,0f,0f);

        }

        if (Input.GetKey("d")){
            this.transform.Translate(0.01f,0f,0f);

        }

        /**
        if (vertical = true){
            if (Input.GetKey("d")){
                this.transform.Translate(0.1f,0f,0f);

            }

            if (Input.GetKey("a")){
                this.transform.Translate(-0.1f,0f,0f);

            }

        }

        **/

        if (Input.GetKey("s")){
            this.transform.Translate(0f,-0.01f,0f);

        }

        

    }

    void Rotate(){
            this.transform.Rotate(0f,0f,90f);
            time = 3.0f;
            //vertical = true;
    
    }

}