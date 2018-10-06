using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {

    private GameObject unitychan;
   

    // Use this for initialization
    void Start () {

        this.unitychan = GameObject.Find("unitychan");


    }

    // Update is called once per frame
    void Update () {

        if(unitychan.transform.position.z >= this.transform.position.z + 5)
        {
            Destroy(this.gameObject);
        }
    }

}
