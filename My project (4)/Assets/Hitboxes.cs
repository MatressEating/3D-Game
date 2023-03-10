using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitboxes : MonoBehaviour
{

    public Collider[] hitbox;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        { 

            LaunchAttack(hitbox[0]);
            
        }
    }

    private void LaunchAttack(Collider col)
    {
        Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("Hitbox"));
        foreach (Collider c in cols)
        {
            Debug.Log(c.name);
            

        }
    }
}
