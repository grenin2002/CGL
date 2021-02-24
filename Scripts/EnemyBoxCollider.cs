using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerBoxCollider();
    }

    private void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
