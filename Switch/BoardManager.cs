using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    class BoardManager
    {
       public  List<Board> Boards = new List<Board>();

        public BoardManager(int noOfBoards,int noOfSwitches)
        {
            for (int i = 0; i < noOfBoards; i++)
                this.Boards.Add(new Board(noOfSwitches));
        }

    }
}
