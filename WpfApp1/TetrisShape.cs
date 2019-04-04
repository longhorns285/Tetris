using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    //Class to store publicly available constants
    public static class Constants
    {
        public const int RECT = 4;
        public const int SIZE = 10;
        public const int HEIGHT = SIZE * 2 * 10;
        public const int WIDTH = SIZE * 2 * 10;
        public const int MIDDLE = WIDTH / 2;
    }

    //Enum used to assign a name to each type of Tetris piece
    public enum ShapeChoice
    {
        Square,
        Pipe,
        RCorner,
        LCorner,
        RZigzag,
        LZigzag,
    }

    class TetrisShape
    {
        //simplify usage of constants in this class
        const int RECT = Constants.RECT;
        const int SIZE = Constants.SIZE;
        const int HEIGHT = Constants.HEIGHT;
        const int WIDTH = Constants.WIDTH;
        const int MIDDLE = Constants.MIDDLE;

        #region TetrisShape Constructor and Methods
        //Constructor that will hold the property of whichever shape is passed into it
        public TetrisShape(ShapeChoice _shape)
        {
            var shape = _shape;
        }

        public int Top()
        {
            return 0;
        }

        public int Left()
        {
            return 0;
        }

        public void RotateLeft()
        {

        }

        public void RotateRight()
        {

        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public void MoveDown()
        {

        }
        #endregion

        #region TetrisSquare Class
        //public class TetrisSquare()
        #endregion

        #region TetrisPipe Class
        //public class TetrisPipe()
        #endregion

        #region TetrisRCorner Class
        //public class TetrisRCorner()
        #endregion

        #region TetrisLCorner Class
        //public class TetrisLCorner()
        #endregion

        #region TetrisRZigzag Class
        //public class TetrisRZigzag()
        #endregion

        #region TetrisLZigzag Class
        //public class TetrisLZigzag()
        #endregion
    }
}
