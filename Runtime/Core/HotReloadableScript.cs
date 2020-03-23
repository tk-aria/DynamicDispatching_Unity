using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AriaPlugin.Runtime.HotReloadable
{
    /// <summary>
    ///  HotReload可能なCSharpスクリプト.
    ///  ※ 編集禁止スクリプト.
    /// </summary>
    public class HotReloadableScript : UniScriptBehaviour
    {
        #region Const
        #endregion // Const End.

        #region Type
        #endregion // Type End.

        #region Field

        [SerializeField] private bool enableAuto = false;
        [SerializeField] private TextAsset script;
        //[SerializeField] private Dictionary<string, UnityEngine.Object> params;

        #endregion // Field End.

        #region Property
        #endregion // Property End.

        #region Event
        #endregion // Event End.

        #region Method

        #region UnityCallback

        /// <summary>
        ///  Unityによって呼び出される.
        /// </summary>
        private void Awake()
        {
            Bind(script.text);
            gameObject.SetActive(enableAuto);
        }

        #endregion // UnityCallback End.

        #endregion // Method End.
    }
}