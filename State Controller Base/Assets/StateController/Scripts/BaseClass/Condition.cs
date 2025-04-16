using UnityEngine;

namespace STATE_CONTROLLER
{
    /// <summary>
    /// Condition is a ScriptableObject that represents a condition in the state machine.
    /// </summary>

    public abstract class Condition : ScriptableObject
    {
        public abstract bool CheckCondition(StateController controller);
    }
}
