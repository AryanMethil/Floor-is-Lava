using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 scaleChange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x<=3){
            transform.localScale += scaleChange;
        }
        else{
            foreach(GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if(gameObj.name == "Ball")
                {
                    gameObj.GetComponent<Renderer>().material.color = new Color(0,255,0);
                }
            }
        }
    }
}
