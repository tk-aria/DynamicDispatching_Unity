using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo2 : UniScriptBehaviour
{
    public Transform m_target;

    private void Awake()
    {
        // Example クラスに DemoScript クラスをバインドして
        // Update 関数が呼び出されるようにする
        Bind
        (
            @"
using UnityEngine;

class DemoScript : Demo2
{
    private void Start()
    {
        this.gameObject.AddComponent<RigidBody>();
    }

    private void Update()
    {
        m_target.position += new Vector3( 0, 0, 1 );
    }
}"
        );
    }
}
