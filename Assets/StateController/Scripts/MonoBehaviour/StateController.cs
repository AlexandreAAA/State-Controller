using UnityEngine;

namespace STATE_CONTROLLER
{     /// <summary>
      /// StateController is a MonoBehaviour that manages the state of a game object.
      /// </summary>

    [AddComponentMenu("StateController/StateControllerBase")]
    public class StateController : MonoBehaviour
    {
        #region Exposed
        public State currentState;
        #endregion

        private void Awake()
        {
            // Initialize the state controller when the game object is loaded.
            // This is where you can set up any initial state or configuration.
        }

        private void Start()
        {
            // Start the state controller when the game object is enabled.
            // This is where you can set up any initial state or configuration.
            // This is where you set up references and dependencies for the state controller.

            if (currentState != null)
            {
                currentState.OnStateEnter(this);
            }
        }

        private void OnEnable()
        {
            // Enable the state controller when the game object is enabled
        }

        private void Update()
        {
            // Update the state controller every frame
            if (currentState != null)
            {
                currentState.OnStateUpdate(this);
            }
        }

        private void FixedUpdate()
        {
            // Update the state controller at fixed intervals for physics calculations
            if (currentState != null)
            {
                currentState.OnStateFixedUpdate(this);
            }
        }
        private void LateUpdate()
        {
            // Update the state controller after all other updates
        }


        private void OnDisable()
        {
            // Disable the state controller when the game object is disabled
        }

        private void OnDestroy()
        {
            // Clean up the state controller when the game object is destroyed
        }



    }

}