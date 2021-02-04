namespace ContrastDemo
{
    using UnityEngine;

    public class FollowPlayer : MonoBehaviour
    {
        [SerializeField]
        private GameObject _player;
        [SerializeField]
        private bool _followY;
        [SerializeField]
        private bool _followX;
        [SerializeField]
        private float _smoothing;

        private Vector3 _startingPosition;

        private void Start()
        {
            _startingPosition = this.gameObject.transform.position;
        }

        private void Update()
        {
            Vector3 newPosition = 
                new Vector3(
                    _followX ? _player.transform.position.x + _startingPosition.x : this.gameObject.transform.position.x,
                    _followY ? _player.transform.position.y + _startingPosition.y : this.gameObject.transform.position.y,
                    _startingPosition.z);
            
            

            this.gameObject.transform.position = newPosition;
        }
    }
}
