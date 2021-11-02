using System;
using System.Collections.Generic;
using System.Text;


namespace Switch
{
    class BoardManager
    {
        public List<Board> Boards = new List<Board>();

        public BoardManager(int noOfBoards)
        {
            for (int i = 0; i < noOfBoards; i++)
            {
                int noOfSwitches = Extension.GetNumericUserValue("How many switches are there in: Board " + (i + 1));
                this.Boards.Add(new Board(noOfSwitches));
            }
        }
    }
}
