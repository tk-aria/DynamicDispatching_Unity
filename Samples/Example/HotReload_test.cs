using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Slowsharp;

public class HotReload_test : MonoBehaviour
{

    public TextAsset script;

    // Start is called before the first frame update
    void Start()
    {

        // C# のコードの定義（Foo クラスの定義）
        var runner = CScript.CreateRunner(script.text);

        // Foo クラスのインスタンスを作成
        var foo = runner.Instantiate( "Foo" );

        // Foo クラスの Sum 関数を呼び出して値を受け取る
        var num = foo.Invoke( "Sum", 1, 2 );

        Debug.Log( num.As<int>() );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
