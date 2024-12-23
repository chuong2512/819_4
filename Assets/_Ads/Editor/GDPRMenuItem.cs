using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GDPRMenuItem : MonoBehaviour
{
    [MenuItem("SansDev/Open GDPR", priority = 0)]
    static void LoadGDPRScene()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/_Ads/_GDPR/GDPR.unity");
        }
    }
}
