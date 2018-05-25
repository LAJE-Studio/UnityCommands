using System;
using UnityEngine;

namespace UnityCommands {
    public abstract class Command : ScriptableObject {
        public abstract string GetIdentifier();
        public abstract void Execute();

        public bool IsSameCommand(Command b) {
            return GetType() == b.GetType();
        }
    }

    public class EditorOnlyAttribute : Attribute { }
}