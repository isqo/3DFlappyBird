using Assets.Levels;
using System;

namespace Assets.Core.Levels
{
    public class LevelManager
    {
        private ILevel Level;
        private static LevelManager _Instance;
        public static LevelManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LevelManager();

                return _Instance;
            }
        }
        public static void Initialize(ILevel level)
        {
            cMoveBird.Reset();
            Score.Reset();
            if (Instance.Level != null)
                Instance.Level.Reset();
            Instance.Level = level;
        }

        public static void Start()
        {
            Instance.Level.Start();
        }
        public static bool IsTheCurrentLevel(Type type)
        {
            if (Instance.Level != null)
                return Instance.Level.GetType() == type;
            return false;
        }
    }
}
