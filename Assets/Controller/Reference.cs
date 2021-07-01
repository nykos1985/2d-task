using UnityEngine;
using UnityEngine.UI;


namespace ManRunner
{
    public class Reference
    {
        private Player _player;
        private Object _environment;
        private Cannon _cannon;
        private SpriteAnimationsConfig _config;

        public Player Player
        {
            get
            {
                if (_player == null)
                {
                    Vector3 playerPosition=new Vector3(-7.50f,-0.77f,1.0f);
                    var gameObject = Resources.Load<Player>("Player");
                    _player = Object.Instantiate(gameObject, playerPosition, Quaternion.identity);
                }

                return _player;
            }
        }

        public Object Environment
        {
            get
            {
                if (_environment == null)
                {
                    Vector3 environmentPosition=new Vector3(-5.468f,-0.907f,1f);
                    var gameObject = Resources.Load<Object>("Environment");
                    _environment = Object.Instantiate(gameObject, environmentPosition, Quaternion.identity);
                }

                return _environment;
            }
        }

        public Cannon Cannon
        {
            get
            {
                if (_cannon == null)
                {
                    Vector3 cannonPosition = new Vector3(-3.95f, 1.37f, 1.0f);
                    var gameObject = Resources.Load<Cannon>("Cannon");
                    _cannon = Object.Instantiate(gameObject, cannonPosition, Quaternion.identity);
                }
                return _cannon;
            }
        }

        public SpriteAnimationsConfig Config
        {
            get
            {
                if(_config==null)
                {
                    _config = Resources.Load<SpriteAnimationsConfig>("SpriteAnimationsConfig");
                }

                return _config;
            }
        }
    }
}