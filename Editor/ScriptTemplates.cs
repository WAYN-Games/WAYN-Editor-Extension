using UnityEditor;

namespace WaynGames.EditorExtension
{
    internal class ScriptTemplates
    {

        public const string TemplatesRoot = "Packages/com.wayn-games.editor.extension/Editor";

        [MenuItem("Assets/Create/WAYN/Editor/ExtendedScriptableObjectDrawer")]
        public static void CreateExtendedScriptableObjectDrawer()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                $"{TemplatesRoot}/ExtendedScriptableObjectDrawerTemplate.txt",
                "ExtendedScriptableObjectDrawer.cs");
        }
       
    }
}
