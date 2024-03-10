using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDemo : MonoBehaviour
{
    LineRenderer _line;

    [SerializeField]
    float _angle;

    Vector2 _direction = Vector2.up;
    Vector2 _endPoint = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        _line = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Mathf.Sin(_angle);
        _direction.y = Mathf.Cos(_angle);

        RaycastHit2D hit;
        hit = Physics2D.Raycast(this.transform.position, _direction, 1000);

        Debug.DrawRay(this.transform.position, _direction * 1000, Color.red);

        if(hit.collider != null)
        {
            _endPoint = hit.point;
        }else
            _endPoint = _direction *= 1000;

        _line.SetPosition(0, this.transform.position);
        _line.SetPosition(1, _endPoint);
    }
}
