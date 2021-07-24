﻿using System;

namespace tarot.Menu{
    public class ListMenu : IMenu{
        private IMenuEntry[] _entries;
        private string _cursor;
        private int _selection = 0;

        public ListMenu(IMenuEntry[] entries, string cursor){
            this._entries = entries;
            this._cursor = cursor;
        }

        public void Up(){
            _selection = Math.Max(_selection - 1, 0);
        }

        public void Down(){
            _selection = Math.Min(_selection + 1, _entries.Length - 1);
        }

        public void Select(){
            _entries[_selection].Select();
        }

        public void Draw(int x, int y){
            for (int i = 0; i < _entries.Length; i++){
                Console.SetCursorPosition(x, y + i);
                Console.Write(" ".Multiply(_cursor.Length + 1));
                Console.SetCursorPosition(x + _cursor.Length, y + i);
                Console.Write(_entries[i].GetText());
            }
            Console.SetCursorPosition(x, y + _selection);
            Console.Write(_cursor);
        }

        public void Left(){
            //DoNothing
        }

        public void Right(){
            //DoNothing
        }
    }
}
