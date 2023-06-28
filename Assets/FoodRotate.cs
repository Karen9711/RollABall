using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRotate : MonoBehaviour
{

    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 1, 0) * _speed);

    }
}
