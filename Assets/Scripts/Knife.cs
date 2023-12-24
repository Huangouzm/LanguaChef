using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;
public class Knife : MonoBehaviour
{
    [SerializeField] private Material matCross;
    void Start()
    {
        
    }
    void Update()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.088f, 0.014f, 0.32f), transform.rotation, ~LayerMask.GetMask("Solid"));
        foreach (Collider c in colliders)
        {
            Destroy(c.gameObject);

            SlicedHull hull = c.gameObject.Slice(transform.position, transform.up); // �������Ϊ��һ����Ƥ
            if (hull != null)
            {
                GameObject lower = hull.CreateLowerHull(c.gameObject, matCross); // �°벿��
                GameObject upper = hull.CreateUpperHull(c.gameObject, matCross); // �ϰ벿��
                GameObject[] objs = new GameObject[] { lower, upper };

                foreach (GameObject obj in objs)
                {
                    Rigidbody rb = obj.AddComponent<Rigidbody>();
                    obj.AddComponent<MeshCollider>().convex = true;
                    obj.name = "TomatoSlice";
                    rb.AddExplosionForce(100, c.gameObject.transform.position, 20); 

                }
            }
        }
    }
}
