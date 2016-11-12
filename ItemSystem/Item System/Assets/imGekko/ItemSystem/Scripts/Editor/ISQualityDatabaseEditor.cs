using UnityEngine;
using System.Collections;
using UnityEditor;


namespace imGekko.ItemSystem.Editor {
        public class ISQualityDatabaseEditor : EditorWindow
        {
            ISQualityDatabase db;

            const string DATABASE_PATH = @"Assests/Database/GekkoQualityDatabase.asset";

            [MenuItem("Gekko/Database/Quality Editor %#i")]
            public static void Init() {
                ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
                window.minSize = new Vector2(400, 300);
                window.title = "Quality Database";
                window.Show();

            }

     
       }



    void OnEnable() {

        db = AssetDatabase.LoadAss

        if (db == null) {
        db = ScriptableObject.CreateInstance<ISQualityDatabase>();
        AssetDatabase.CreateAsset(db, DATABASE_PATH);
        AssetDatabase.SaveAssets();
        }
    }
}