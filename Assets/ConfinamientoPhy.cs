using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfinamientoPhy : MonoBehaviour
{
    public List<Collider2D> ignoreList;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ignoreList.Count; i++)
        {
            Physics2D.IgnoreCollision(ignoreList[i], GetComponent<Collider2D>());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
