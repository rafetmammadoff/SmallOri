using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform PlayerTransform;
    [SerializeField] float offset=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerTransform.position.x+offset, transform.position.y, transform.position.z);
    }
}
