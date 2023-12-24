using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Spillter : MonoBehaviour
{
    [SerializeField] private Material matCross;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        transform.Rotate(0, 0, -mx);

        if (Input.GetMouseButtonDown(0))
        {
            Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(6.43f, 0.005f, 12.5f), transform.rotation, ~LayerMask.GetMask("Solid"));

            foreach (Collider c in colliders)
            {
                Destroy(c.gameObject);
                // GameObject[] objs = c.gameObject.SliceInstantiate(transform.position,transform.up); 

                SlicedHull hull = c.gameObject.Slice(transform.position, transform.up); // 可以理解为是一个表皮
                if (hull != null)
                {
                    GameObject lower = hull.CreateLowerHull(c.gameObject, matCross); // 下半部分
                    GameObject upper = hull.CreateUpperHull(c.gameObject, matCross); // 上半部分
                    GameObject[] objs = new GameObject[] { lower, upper };

                    foreach (GameObject obj in objs)
                    {
                        Rigidbody rb = obj.AddComponent<Rigidbody>();
                        // obj.AddComponent<Rigidbody>();
                        obj.AddComponent<MeshCollider>().convex = true;
                        obj.name = "potato_slice";
                        rb.AddExplosionForce(100, c.gameObject.transform.position, 30); 
                    }
                }
            }
        }
    }
}