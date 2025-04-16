using UnityEngine;

namespace STATE_CONTROLLER
{
    public abstract class StateAction : ScriptableObject
    {
        public abstract void Execute(StateController controller);
    }
}
