using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject _eater;
    private Vector3 _offset;
    private Vector3 _y_offset;
    private float _y_delta;
    // Start is called before the first frame update
    void Start()
    {
        _offset = this.transform.position - _eater.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = _offset + _eater.transform.position;
    }

    
}
