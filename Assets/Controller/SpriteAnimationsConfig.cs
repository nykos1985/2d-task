using System;
using System.Collections.Generic;
using UnityEngine;

namespace ManRunner
{
    public enum Track
        {
            man_run,
            man_jump,
            man_idle,
            man_fall
        }

        [CreateAssetMenu(fileName = "SpriteAnimationsConfig", menuName = "Configs/SpriteAnimationsConfig", order = 1)]
        public class SpriteAnimationsConfig : ScriptableObject
        {
            [Serializable]
            public class SpritesSequence
            {
                public Track Track;
                public List<Sprite> Sprites = new List<Sprite>();
            }
            public List<SpritesSequence> Sequences = new List<SpritesSequence>();
        }
}
    