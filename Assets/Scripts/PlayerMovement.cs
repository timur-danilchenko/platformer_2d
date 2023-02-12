using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force = 10.0f;
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = _rigidbody2D.position + new Vector2(1, 0) * Input.GetAxis("Horizontal");
        _rigidbody2D.MovePosition(position);
    }
}
