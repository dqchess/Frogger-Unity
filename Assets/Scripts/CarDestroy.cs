using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDestroy : MonoBehaviour {

    public GameObject gameObject;

    void Update()
    {
        Destroy(gameObject, 5f);
    }
}
