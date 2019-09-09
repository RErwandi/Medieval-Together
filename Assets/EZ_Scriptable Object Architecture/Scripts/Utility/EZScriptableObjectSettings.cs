using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public class EZScriptableObjectSettings : ScriptableObject
    {
        public static EZScriptableObjectSettings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = GetInstance();

                return _instance;
            }
        }

        private static EZScriptableObjectSettings _instance;

        private static EZScriptableObjectSettings GetInstance()
        {
            EZScriptableObjectSettings instance =
                Resources.Load<EZScriptableObjectSettings>("EZ_ScriptableObject_Settings");

            if (instance == null)
                return CreateInstance();

            return instance;
        }

        private static EZScriptableObjectSettings CreateInstance()
        {
#if UNITY_EDITOR
            EZScriptableObjectSettings newSettings =
                CreateInstance<EZScriptableObjectSettings>();

            if (!UnityEditor.AssetDatabase.IsValidFolder("Assets/Resources"))
                UnityEditor.AssetDatabase.CreateFolder("Assets", "Resources");

            UnityEditor.AssetDatabase.CreateAsset(newSettings, "Assets/Resources/EZScriptableObjectSettings.asset");
            UnityEditor.AssetDatabase.SaveAssets();

            UnityEditor.Selection.activeObject = newSettings;

            Debug.LogWarning(
                "No EZ_ScriptableObject_Settings asset found! Creating new one, ensure it's locatable by Resources",
                newSettings);

            return newSettings;
#else
            throw new System.NullReferenceException();
#endif
        }
    }
}