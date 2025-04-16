using System;

namespace STATE_CONTROLLER
{
    /// <summary>
    /// Transition is a ScriptableObject that represents a transition in the state machine.
    /// </summary>

    [Serializable]
    public class Transition
    {
        public int id;
        public Condition condition;
        public State targetState;
        public bool disable;
    }

}

