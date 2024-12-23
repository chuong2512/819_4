using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CustomMenuItem : MonoBehaviour
{
    [MenuItem("SansDev/Open Game Scene", priority = 1)]
    static void LoadGameScene()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/_Game/Scenes/Game.unity");
        }
    }

    [MenuItem("SansDev/Customize/Credit Panel")]
    static void OpenCreditData()
    {
        string path = "Assets/_Game/SO/Credit Data.asset";
        CreditDataSO data = (CreditDataSO)AssetDatabase.LoadAssetAtPath(path, typeof(CreditDataSO));
        Selection.activeObject = data;
    }

    [MenuItem("SansDev/Customize/Audio Data")]
    static void OpenAudioData()
    {
        string path = "Assets/_Game/SO/Audio Data.asset";
        AudioDataSO data = (AudioDataSO)AssetDatabase.LoadAssetAtPath(path, typeof(AudioDataSO));
        Selection.activeObject = data;
    }

    [MenuItem("SansDev/Customize/Background Color Data")]
    static void OpenBackgroundColorData()
    {
        string path = "Assets/_Game/SO/Gradient Data.asset";
        GradientDataSO data = (GradientDataSO)AssetDatabase.LoadAssetAtPath(path, typeof(GradientDataSO));
        Selection.activeObject = data;
    }
}
