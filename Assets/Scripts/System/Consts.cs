using System.Collections.Generic;
using UnityEngine;

namespace Constants
{
    public static class Consts
    {
        public const int SET_LIMIT = 15;
        public const float GAME_TIME = 100f;

        public static readonly Dictionary<SceneNames, string> Scenes = new()
        {
            [SceneNames.TITLE_SCENE] = "TitleScene",
            [SceneNames.GAME_SCENE] = "GameScene",
            [SceneNames.RESULT_SCENE] = "ResultScene",
        };
    }

    public enum SceneNames
    {
        TITLE_SCENE,
        GAME_SCENE,
        RESULT_SCENE,
    }
}
