using UnityEngine;

namespace acornassets
{
    public class CharacterAnimationSample : MonoBehaviour
    {
        [SerializeField] private Animator _animatorRef;
        [Range(0f, 1f)][SerializeField] private float _animSpeed = 1f;

        private const string SPEED_PARAM_NAME = "Speed";

        void LateUpdate()
        {
            if (_animatorRef != null)
            {
                _animatorRef.SetFloat(SPEED_PARAM_NAME, _animSpeed);
            }
        }
    }
}