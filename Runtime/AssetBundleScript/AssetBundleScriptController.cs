using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AriaPlugin.Runtime.CSharpHotReload
{
    /// <summary>
    ///  アセットバンドルスクリプトの制御.
    /// </summary>
    public class AssetBundleScriptController
    {
        #region Const
        #endregion // Const End.

        #region Type
        #endregion // Type End.

        #region Field

        [SerializeField] AssetBundleScript bundleScript;

        #endregion // Field End.

        #region Property
        #endregion // Property End.

        #region Event
        #endregion // Event End.

        #region Method

        /// <summary>
        ///  
        /// </summary>
        public AssetBundleScriptController(AssetBundleScript bundleScript)
        {
            this.bundleScript = bundleScript;
        }

        public void Initialize()
        {
            bundleScript.gameObject.SetActive(true);
        }

        #endregion // Method End.
    }
}