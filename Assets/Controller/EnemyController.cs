using UnityEngine;


namespace ManRunner
{
    public class EnemyController : IExecute
    {
        private Transform _muzzleTransform;
        private Transform _aimTransform;

        public EnemyController(Transform muzzleTransform, Transform aimTransform)
        {
            _muzzleTransform = muzzleTransform;
            _aimTransform = aimTransform;
        }

        public void Execute()
        {
            var dir = _aimTransform.position - _muzzleTransform.position;
            var angle = Vector3.Angle(Vector3.down, dir);
            var axis = Vector3.Cross(Vector3.down, dir);
            _muzzleTransform.rotation = Quaternion.AngleAxis(angle, axis);

        }
    }
}