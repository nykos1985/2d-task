using System;
using UnityEngine;


namespace ManRunner
{
    public class Player : PlayerBase
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] public SpriteRenderer spriteRenderer;
        [SerializeField] private SpriteAnimator _spriteAnimator;
        [SerializeField] private Collider2D _collider;
        private ContactsPoller _contactPoller;
        private Vector3 _leftScale = new Vector3(-1, 1, 1);
        private Vector3 _rightScale = new Vector3(1, 1, 1);

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            _collider = GetComponent<Collider2D>();
            _contactPoller = new ContactsPoller(_collider);
            SpriteAnimationsConfig config = Resources.Load<SpriteAnimationsConfig>("PlayerCfg");
            _spriteAnimator = new SpriteAnimator(config);
            _spriteAnimator.StartAnimation(spriteRenderer, Track.man_idle, true, 12);
        }

        public void FixedUpdate()
        {
            _contactPoller.Update();
        }

        public override void Move(float x, float y)
        {
            if (!_contactPoller.IsGrounded) y = 0;
            Debug.Log(_contactPoller.IsGrounded);
            _rigidbody.velocity = new Vector2(x * speed, y * jumpForce);

            _rigidbody.transform.localScale = (x < 0 ? _leftScale : _rightScale);
            _spriteAnimator.Update();

            _spriteAnimator.StartAnimation(spriteRenderer, Track.man_run, true, 12);
        }
    }
}