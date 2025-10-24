using UnityEditor;

public static class BuildAutomator
{
    [MenuItem("Build/Window")]
    public static void Build()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();

        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "C:\\UnityBuild\\AppName.exe";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows;
        buildPlayerOptions.options = BuildOptions.Development;

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
