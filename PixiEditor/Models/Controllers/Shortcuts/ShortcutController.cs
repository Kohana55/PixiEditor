﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PixiEditor.Models.Controllers.Shortcuts
{
    public class ShortcutController
    {
        public static bool BlockShortcutExecution { get; set; }

        public List<Shortcut> Shortcuts { get; set; }

        public ShortcutController()
        {
            Shortcuts = new List<Shortcut>();
        }

        public void KeyPressed(Key key, ModifierKeys modifiers)
        {
            if (!BlockShortcutExecution)
            {
                Shortcut[] shortcuts = Shortcuts.FindAll(x => x.ShortcutKey == key).ToArray();
                if (shortcuts.Length < 1) return;
                shortcuts = shortcuts.OrderByDescending(x => x.Modifier).ToArray();
                for (int i = 0; i < shortcuts.Length; i++)
                    if (modifiers.HasFlag(shortcuts[i].Modifier))
                    {
                        shortcuts[i].Execute();
                        break;
                    }
            }
        }
    }
}