using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed;

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;
        transform.Translate(Input.GetAxis("Horizontal")*step, 0f, Input.GetAxis("Vertical")* step);

    }
}
