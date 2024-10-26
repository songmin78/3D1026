using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField] float Speed = 2;
    // Start is called before the first frame update

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void playMove()
    {
        if(Input.GetKey(KeyCode.W))
        {

        }
    }
}
