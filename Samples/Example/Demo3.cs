using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Slowsharp;

public class Demo3 : MonoBehaviour
{
    private CScript m_runner;

    private void Start()
    {
        m_runner = CScript.CreateRunner
        (
            @"
public class Foo
{ 
    public int Sum( int x, int y ) => x + y; 
}
"
        );
    }

    private void Update()
    {
        if ( Input.GetKeyDown( ( KeyCode.Space ) ) )
        {
            m_runner.UpdateMethodsOnly
            (
                @"
public class Foo
{ 
    public int Sum( int x, int y ) => x * y; 
}
" );
        }
        
        var foo = m_runner.Instantiate( "Foo" );

        var num = foo.Invoke( "Sum", 1, 2 );

        Debug.Log( num.As<int>() );
    }
}
