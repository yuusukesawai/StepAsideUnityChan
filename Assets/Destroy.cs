﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
