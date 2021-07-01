using UnityEngine;


namespace ManRunner
{

    public class GameStarter : MonoBehaviour
    {

        private InputController _inputController;
        private EnemyController _enemyController;
        private ExecutableObjects _interactiveObjects;
        private Reference _reference;
        private Object _environment;
        

        private void Awake()
        {
            _reference = new Reference();

            _interactiveObjects = new ExecutableObjects();

            _inputController = new InputController(_reference.Player);
            _interactiveObjects.AddExecutableObject(_inputController);

            _environment=_reference.Environment;
            
            _enemyController=new EnemyController(_reference.Cannon.transform.GetChild(0).transform,_reference.Player.transform);
            _interactiveObjects.AddExecutableObject(_enemyController);

        }
        

        private void FixedUpdate()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }

                interactiveObject.Execute();
            }
        }
    }
}

