using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    [SerializeField]
    Collider2D _colli;

    [SerializeField] LineRenderer _line;
    // Start is called before the first frame update
    void Start()
    {
        _colli = this.GetComponent<Collider2D>();

        _line.SetPosition(0, Vector3.zero);

        Vector3[] point = new Vector3[10];

        _line.SetPositions(point);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D[] hits = new RaycastHit2D[10];

        _colli.Cast(Vector2.down, hits, 100, false);

        foreach(RaycastHit2D h in hits)
        {
            if (h.collider == null)
                continue;

            Debug.LogError(h.collider.gameObject.name);
        }    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.LogError(this.name + " Hittt " + collision.gameObject.name);
    }

}
