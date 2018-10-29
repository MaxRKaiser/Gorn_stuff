using UnityEditor;
using UnityEngine;
using UnityEditor.Build;
using System.IO;

public class AssetBundleCreator : EditorWindow {

    [MenuItem("MemeLoader/Export Bundle")]
    static void ShowWindow ()
    {
        AssetBundleCreator window = (AssetBundleCreator)GetWindow (typeof(AssetBundleCreator));
        window.Show ();
    }

    private void OnGUI ()
    {
        if (GUILayout.Button ( "Export" )) {

            if (!Directory.Exists ( Application.dataPath + "/MyExportedWeapon" ))
                Directory.CreateDirectory ( Application.dataPath + "/MyExportedWeapon" );

            BuildAllAssetBundles ();

            AssetBundleCreator window = (AssetBundleCreator)GetWindow ( typeof ( AssetBundleCreator ) );
            window.Close ();
        }
    }

    private void BuildAllAssetBundles ()
    {

        BuildPipeline.BuildAssetBundles ( Application.dataPath + "/MyExportedWeapon", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64 );
    }
}