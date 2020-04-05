using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Chess.Model;
using System.Net.Http.Headers;
using Chess.Controler;

namespace Chess
{
    public class GameBoardManager
    {
        #region Properties
        Panel gameBoard = new Panel();
        public Panel GameBoard { get => gameBoard; set => gameBoard = value; }

        Controller controller = new Controller();
        
        #endregion
        Firgure King = new KingFirgure();


        #region Intialize
        public GameBoardManager (Panel gameboard)
        {
            this.gameBoard = gameboard;
        }
        #endregion

        #region Methods



        public void DrawGameBoard()
        { 
            new  Setting();

            controller.DrawMatrix(gameBoard);
        }
        #endregion
    }
}
