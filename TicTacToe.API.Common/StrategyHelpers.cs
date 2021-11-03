using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.API.Common
{
    public static class StrategyHelpers
    {
        public static bool Win(char one, char two, char three, char player, int[] winPossible, int[] coordinates)
        {
            int win = 0;
            win = PlayerMatch(one, player, win);
            win = PlayerMatch(two, player, win);
            win = PlayerMatch(three, player, win);
            if (win >= 2)
            {
                if (!(SpaceMatch(one, winPossible, coordinates[0], coordinates[1])))
                {
                    if (!(SpaceMatch(two, winPossible, coordinates[2], coordinates[3])))
                    {
                        if (!(SpaceMatch(three, winPossible, coordinates[4], coordinates[5])))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            return false;
        }

        public static int PlayerMatch(char item, char player, int win)
        {
            if (item.Equals(player))
            {
                win++;
            }
            return win;
        }

        public static bool SpaceMatch(char item, int[] winPossible, int row, int column)
        {
            if (item.Equals(Constants.SPACE))
            {
                winPossible[0] = row;
                winPossible[1] = column;
                return true;
            }
            return false;
        }

        public static bool WinRowOne(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[0][0];
            char two = boardMatrix[0][1];
            char three = boardMatrix[0][2];
            int[] coordinates = new int[6] { 0, 0, 0, 1, 0, 2 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool WinRowTwo(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[1][0];
            char two = boardMatrix[1][1];
            char three = boardMatrix[1][2];
            int[] coordinates = new int[6] { 1, 0, 1, 1, 1, 2 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool WinRowThree(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[2][0];
            char two = boardMatrix[2][1];
            char three = boardMatrix[2][2];
            int[] coordinates = new int[6] { 2, 0, 2, 1, 2, 2 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool WinColumnOne(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[0][0];
            char two = boardMatrix[1][0];
            char three = boardMatrix[2][0];
            int[] coordinates = new int[6] { 0, 0, 1, 0, 2, 0 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool WinColumnTwo(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[0][1];
            char two = boardMatrix[1][1];
            char three = boardMatrix[2][1];
            int[] coordinates = new int[6] { 0, 1, 1, 1, 2, 1 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool WinColumnThree(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[0][2];
            char two = boardMatrix[1][2];
            char three = boardMatrix[2][2];
            int[] coordinates = new int[6] { 0, 2, 1, 2, 2, 2 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool WinDiagonalOne(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[0][0];
            char two = boardMatrix[1][1];
            char three = boardMatrix[2][2];
            int[] coordinates = new int[6] { 0, 0, 1, 1, 2, 2 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool WinDiagonalTwo(char[][] boardMatrix, char player, int[] winPossible)
        {
            char one = boardMatrix[0][2];
            char two = boardMatrix[1][1];
            char three = boardMatrix[2][0];
            int[] coordinates = new int[6] { 0, 2, 1, 1, 2, 0 };
            return Win(one, two, three, player, winPossible, coordinates);
        }

        public static bool OppositeCorner(char corner, char oppositeCorner, char player, int[] cornerPossible, int row, int column)
        {
            if (corner.Equals(player) && oppositeCorner.Equals(Constants.SPACE))
            {
                cornerPossible[0] = row;
                cornerPossible[1] = column;
                return true;
            }
            return false;
        }

        public static bool OppositeCornerOne(char[][] boardMatrix, char player, int[] cornerPossible)
        {
            char corner = boardMatrix[0][0];
            char oppositeCorner = boardMatrix[2][2];

            return OppositeCorner(corner, oppositeCorner, player, cornerPossible, 2, 2);
        }

        public static bool OppositeCornerTwo(char[][] boardMatrix, char player, int[] cornerPossible)
        {
            char corner = boardMatrix[0][2];
            char oppositeCorner = boardMatrix[2][0];

            return OppositeCorner(corner, oppositeCorner, player, cornerPossible, 2, 0);
        }

        public static bool OppositeCornerThree(char[][] boardMatrix, char player, int[] cornerPossible)
        {
            char corner = boardMatrix[2][0];
            char oppositeCorner = boardMatrix[0][2];

            return OppositeCorner(corner, oppositeCorner, player, cornerPossible, 0, 2);
        }

        public static bool OppositeCornerFour(char[][] boardMatrix, char player, int[] cornerPossible)
        {
            char corner = boardMatrix[2][2];
            char oppositeCorner = boardMatrix[0][0];

            return OppositeCorner(corner, oppositeCorner, player, cornerPossible, 0, 0);
        }

        public static bool Empty(char corner, int[] emptyPossible, int row, int column)
        {
            if (corner.Equals(Constants.SPACE))
            {
                emptyPossible[0] = row;
                emptyPossible[1] = column;
                return true;
            }
            return false;
        }

        public static bool EmptyCornerOne(char[][] boardMatrix, int[] emptyCornerPossible)
        {
            char corner = boardMatrix[0][0];

            return Empty(corner, emptyCornerPossible, 0, 0);
        }

        public static bool EmptyCornerTwo(char[][] boardMatrix, int[] emptyCornerPossible)
        {
            char corner = boardMatrix[0][2];

            return Empty(corner, emptyCornerPossible, 0, 2);
        }

        public static bool EmptyCornerThree(char[][] boardMatrix, int[] emptyCornerPossible)
        {
            char corner = boardMatrix[2][0];

            return Empty(corner, emptyCornerPossible, 2, 0);
        }

        public static bool EmptyCornerFour(char[][] boardMatrix, int[] emptyCornerPossible)
        {
            char corner = boardMatrix[2][2];

            return Empty(corner, emptyCornerPossible, 2, 2);
        }

        public static bool EmptySideOne(char[][] boardMatrix, int[] emptySidePossible)
        {
            char corner = boardMatrix[0][1];

            return Empty(corner, emptySidePossible, 0, 1);
        }

        public static bool EmptySideTwo(char[][] boardMatrix, int[] emptySidePossible)
        {
            char corner = boardMatrix[1][0];

            return Empty(corner, emptySidePossible, 1, 0);
        }

        public static bool EmptySideThree(char[][] boardMatrix, int[] emptySidePossible)
        {
            char corner = boardMatrix[2][1];

            return Empty(corner, emptySidePossible, 2, 1);
        }

        public static bool EmptySideFour(char[][] boardMatrix, int[] emptySidePossible)
        {
            char corner = boardMatrix[1][2];

            return Empty(corner, emptySidePossible, 1, 2);
        }

        public static bool ForkBlockCorner(char[][] boardMatrix, char corner, char oppositeCorner, int[] emptySidePossible)
        {
            char centre = boardMatrix[1][1];
            if (corner.Equals(Constants.PLAYER_X) && oppositeCorner.Equals(Constants.PLAYER_X) && centre.Equals(Constants.PLAYER_O))
            {
                if (EmptySideOne(boardMatrix, emptySidePossible)
                || EmptySideTwo(boardMatrix, emptySidePossible)
                || EmptySideThree(boardMatrix, emptySidePossible)
                || EmptySideFour(boardMatrix, emptySidePossible))
                {                    
                    return true;
                }
            }
            return false;
        }

        public static bool ForkBlockCornerOne(char[][] boardMatrix, int[] emptySidePossible)
        {
            char corner = boardMatrix[0][0];
            char oppositeCorner = boardMatrix[2][2];

            return ForkBlockCorner(boardMatrix, corner, oppositeCorner, emptySidePossible);
        }

        public static bool ForkBlockCornerTwo(char[][] boardMatrix, int[] emptySidePossible)
        {
            char corner = boardMatrix[0][2];
            char oppositeCorner = boardMatrix[2][0];

            return ForkBlockCorner(boardMatrix, corner, oppositeCorner, emptySidePossible);
        }
    }
}
