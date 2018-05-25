using System;
using System.Collections.Generic;
using UnityEngine;
using UnityUtilities.Singletons;

namespace UnityCommands {
    public class CommandDatabase : ScriptableSingleton<CommandDatabase> {
        [SerializeField, HideInInspector]
        private List<Command> Commands = new List<Command>();

        public bool RegisterCommand(Command c) {
            if (HasCommand(c)) {
                Debug.LogWarningFormat("[UnityCommands] Command {0} is already registered", c);
                return false;
            }

            Commands.Add(c);
            return true;
        }

        public bool HasCommand<T>(bool allowedSubClasses = false) {
            return HasCommand(typeof(T), allowedSubClasses);
        }

        private bool HasCommand(Type commandType, bool allowSubClasses = false) {
            foreach (var command in Commands) {
                var t = command.GetType();
            }

            return false;
        }

        public bool HasCommand(Command command) {
            foreach (var c in Commands) {
                if (c.IsSameCommand(command)) {
                    return true;
                }
            }

            return false;
        }
    }
}