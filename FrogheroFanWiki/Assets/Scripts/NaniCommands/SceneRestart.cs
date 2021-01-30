using Naninovel;
using Naninovel.Commands;
using UniRx.Async;
using UnityEngine;
using UnityEngine.SceneManagement;

[CommandAlias("sceneRestart")]
public class SceneRestart : Command
{

    public override UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        Debug.Log("Game Restart");
        SceneManager.LoadScene("MainGame");
        return UniTask.CompletedTask;
    }
}