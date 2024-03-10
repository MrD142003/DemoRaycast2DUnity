using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject enemyJustSpaw = Instantiate(enemy, this.transform.position, Quaternion.identity);

            enemyJustSpaw.transform.Translate(Vector3.zero);
        }
        
    }
}
