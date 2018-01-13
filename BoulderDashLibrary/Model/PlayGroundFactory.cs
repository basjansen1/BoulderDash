using BoulderDashLibrary.Model.Squares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model
{
    public class PlayGroundFactory
    {
        public Dictionary<string, List<PlayElement>> PlayElements { get; private set; }

        public PlayGroundFactory()
        {
            PlayElements = new Dictionary<string, List<PlayElement>>();
            PlayElements["Players"] = new List<PlayElement>();
            PlayElements["Gatherables"] = new List<PlayElement>();
            PlayElements["Enemies"] = new List<PlayElement>();
            PlayElements["Exits"] = new List<PlayElement>();
        }
        public Square CreatePlayGround(string[] rows)
        {
            // From string [] to square[][]
            Square[][] squares = new Square[rows.Length][];
            int arrayIndex = 0;

            foreach (string row in rows)
            {
                squares[arrayIndex] = new Square[row.Length];
                int rowIndex = 0;
                foreach (char square in row)
                {
                    Square currentSquare = null;
                    PlayElement playElement = null;
                    switch(square)
                    {
                        case 'R':
                            currentSquare = new NormalSquare();
                            playElement = new Rockford(currentSquare);
                            PlayElements["Players"].Add(playElement);
                            break;
                        case 'M':
                            currentSquare = new MudSquare();
                            break;
                        case 'B':
                            currentSquare = new NormalSquare();
                            playElement = new Boulder(currentSquare);
                            break;
                        case 'D':
                            currentSquare = new NormalSquare();
                            playElement = new Diamond(currentSquare);
                            PlayElements["Gatherables"].Add(playElement);
                            break;
                        case 'W':
                            currentSquare = new NormalSquare();
                            playElement = new NormalWall(currentSquare);
                            break;
                        case 'S':
                            currentSquare = new NormalSquare();
                            playElement = new SteelWall(currentSquare);
                            break;
                        case 'F':
                            currentSquare = new NormalSquare();
                            playElement = new FireFly(currentSquare);
                            PlayElements["Enemies"].Add(playElement);
                            break;
                        case 'E':
                            currentSquare = new NormalSquare();
                            playElement = new ExitWall(currentSquare);
                            PlayElements["Exits"].Add(playElement);
                            break;
                        case ' ':
                            currentSquare = new NormalSquare();
                            break;
                    }
                    if(playElement != null)
                    {
                        currentSquare.AddPlayElement(playElement);
                    }
                    squares[arrayIndex][rowIndex] = currentSquare;
                    rowIndex++;
                    Console.Write(currentSquare.GetPrintShape()); // remove line
                }
                arrayIndex++;
                Console.WriteLine(); // remove line
            }
            AssignPlayersToEnemies();
            AssignSideSquares(squares);
            return squares[0][0]; // return first square of the sequence
        }

        private void AssignSideSquares(Square[][] squares)
        {
            for (int arrayIndex = 0; arrayIndex < squares.Length; arrayIndex++)
            {
                Square[] previousSquareArray = null;
                Square[] currentSquareArray = squares[arrayIndex];
                Square[] nextSquareArray = null;

                if ((arrayIndex -1) >= 0)
                {
                    previousSquareArray = squares[arrayIndex - 1];
                } 

                if ((arrayIndex + 1) != squares.Length)
                {
                    nextSquareArray = squares[arrayIndex + 1];
                }

                for (int rowIndex = 0; rowIndex < currentSquareArray.Length; rowIndex++)
                {
                    // assign left square
                    if ((rowIndex - 1) >= 0)
                    {
                        currentSquareArray[rowIndex].LeftSquare = currentSquareArray[rowIndex - 1];
                    }
                    // assign right square
                    if ((rowIndex + 1) != currentSquareArray.Length)
                    {
                        currentSquareArray[rowIndex].RightSquare = currentSquareArray[rowIndex + 1];
                    }
                    // assign up square
                    if (previousSquareArray != null && (rowIndex <= previousSquareArray.Length))
                    {
                        currentSquareArray[rowIndex].UpSquare = previousSquareArray[rowIndex];
                    }
                    // assign down square
                    if (nextSquareArray != null && (rowIndex <= nextSquareArray.Length))
                    {
                        currentSquareArray[rowIndex].DownSquare = nextSquareArray[rowIndex];
                    }
                }
            }
        }
        private void AssignPlayersToEnemies()
        {
            foreach (PlayElement playerElement in PlayElements["Players"])
            {
                Player player = (Player)playerElement;
                foreach (PlayElement enemyElement in PlayElements["Enemies"])
                {
                    Enemy enemy = (Enemy)enemyElement;
                    enemy.AddPlayer(player);
                }
            }
        }
    }
}
