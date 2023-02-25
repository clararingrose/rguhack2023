
using UnityEngine;
using System.Collections;

public class tetrisBlock : MonoBehaviour {
    //Ininitialise variables
    public GameObject block;

    void Start(){
    //Give variables values

    }

    void Update(){
    //Processes/Instructions
        if (Input.GetKey("w")){
            this.transform.Translate(0f,0.01f,0f);

        }

        if (Input.GetKey("d")){
            this.transform.Translate(0.01f,0f,0f);

        }

        if (Input.GetKey("a")){
            this.transform.Translate(-0.01f,0f,0f);

        }

        if (Input.GetKey("s")){
            this.transform.Translate(0f,-0.01f,0f);

        }


    }

    void Rotate(){
        this.transform.Rotate(0f,0f,90f);
        
    }

}