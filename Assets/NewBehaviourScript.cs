using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform cube;
    public Transform capsule;
    [Range(0, 1)] public float alpha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alpha += Time.deltaTime / 5;
        alpha= Mathf.Clamp(alpha, 0, 1);
        transform.position = Vector3.Lerp(cube.position, capsule.position, alpha);
    }
}
