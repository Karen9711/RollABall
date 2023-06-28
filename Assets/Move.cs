using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody _rd;
    private int _curScord;
    public TextMeshProUGUI _scord;
    public TextMeshProUGUI _winText;
    public float _force;
    private int _maxScord;
    // Start is called before the first frame update
    void Start()
    {
        _rd = this.GetComponent<Rigidbody>();
        _curScord = 0;
        _scord.text = "Scord:" + _curScord;
        _winText.enabled = false;
        _maxScord = 6;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        _rd.AddForce(new Vector3(_force * h, 0, _force * v));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Food"))
        {
            ++_curScord;
            _scord.text = "Scord:" + _curScord;
            Destroy(other.gameObject);

            if (_curScord == _maxScord) {
                Debug.Log("win");
                _winText.enabled = true;
            }
        }
    }
}
