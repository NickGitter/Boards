using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutBoards
{
    public static class CutBoardSettings
    {
        public static double MinBoardLength = 0.1;
    }
    public class CuttedBoard
    {
        public List<double> Cutts { get; set; } = new List<double>();
        public double Mod { get; set; } = 0;
    }
    public abstract class CutBoardStrategyBase
    {
        protected bool CheckCorrect(double boardLength, List<double> neededBoards, out string errorStr)
        {
            if (boardLength < 0)
            {
                errorStr = "Длина стандартной доски меньше нуля";
                return false;
            }
            if (boardLength < CutBoardSettings.MinBoardLength)
            {
                errorStr = string.Format("Длина стандартной доски меньше минимально-допустимого: {0}", CutBoardSettings.MinBoardLength);
                return false;
            }
            for (int i = 0; i < neededBoards.Count; ++i)
            {
                if (neededBoards[i] < 0)
                {
                    errorStr = string.Format("Длина требуемой доски №{0} меньше нуля",(i+1));
                    return false;
                }
                if (neededBoards[i] < CutBoardSettings.MinBoardLength)
                {
                    errorStr = string.Format("Длина требуемой доски №{0} меньше минимально-допустимого: {1}", (i+1), CutBoardSettings.MinBoardLength);
                    return false;
                }
                if (neededBoards[i] > boardLength)
                {
                    errorStr = string.Format("Длина требуемой доски №{0} больше чем стандартная доска", (i + 1));
                    return false;
                }
            }
            errorStr = "Все корректно";
            return true;
        }
        public abstract List<CuttedBoard> CutBoard(double boardLength, List<double> neededBoards);
    }
    public class CutBoardSortedFromHeightToLowStrategy : CutBoardStrategyBase
    {
        public override List<CuttedBoard> CutBoard(double boardLength, List<double> neededBoards)
        {
            string errorStr;
            if (!CheckCorrect(boardLength, neededBoards, out errorStr))
            {
                throw new Exception(errorStr);
            }

            double curBoardLength = boardLength;
            List<CuttedBoard> returnBoardsLengths = new List<CuttedBoard>();
            CuttedBoard CB;
            bool bFind = false;
            int findedI = 0;
            neededBoards.Sort((double a, double b) => { if (a == b) return 0; if (a < b) return 1; return -1; });
            do
            {
                CB = new CuttedBoard(); // Подготавливаем новую доску
                curBoardLength = boardLength;
                do
                {
                    bFind = false;
                    for (int i = 0; (!bFind) && (i < neededBoards.Count); ++i)
                    {
                        if (neededBoards[i] <= curBoardLength)
                        {
                            curBoardLength -= neededBoards[i];
                            CB.Cutts.Add(neededBoards[i]);
                            bFind = true;
                            findedI = i;
                        }
                    }
                    if (bFind)
                    {
                        neededBoards.RemoveAt(findedI);
                    }
                } while (bFind);
                CB.Mod = curBoardLength;
                returnBoardsLengths.Add(CB);
            } while (neededBoards.Count != 0);

            return returnBoardsLengths;
        }
    }

    public class CutBoardSortedFromLowToHeightStrategy : CutBoardStrategyBase
    {
        public override List<CuttedBoard> CutBoard(double boardLength, List<double> neededBoards)
        {
            string errorStr;
            if (!CheckCorrect(boardLength, neededBoards, out errorStr))
            {
                throw new Exception(errorStr);
            }

            double curBoardLength = boardLength;
            List<CuttedBoard> returnBoardsLengths = new List<CuttedBoard>();
            CuttedBoard CB;
            bool bFind = false;
            int findedI = 0;
            neededBoards.Sort((double a, double b) => { if (a == b) return 0; if (a < b) return -1; return 1; });
            do
            {
                CB = new CuttedBoard(); // Подготавливаем новую доску
                curBoardLength = boardLength;
                do
                {
                    bFind = false;
                    for (int i = 0; (!bFind) && (i < neededBoards.Count); ++i)
                    {
                        if (neededBoards[i] <= curBoardLength)
                        {
                            curBoardLength -= neededBoards[i];
                            CB.Cutts.Add(neededBoards[i]);
                            bFind = true;
                            findedI = i;
                        }
                    }
                    if (bFind)
                    {
                        neededBoards.RemoveAt(findedI);
                    }
                } while (bFind);
                CB.Mod = curBoardLength;
                returnBoardsLengths.Add(CB);
            } while (neededBoards.Count != 0);

            return returnBoardsLengths;
        }
    }
    public class CutBoardSimpleStrategy : CutBoardStrategyBase
    {
        public override List<CuttedBoard> CutBoard(double boardLength, List<double> neededBoards)
        {
            string errorStr;
            if (!CheckCorrect(boardLength, neededBoards, out errorStr))
            {
                throw new Exception(errorStr);
            }

            double curBoardLength = boardLength;
            List<CuttedBoard> returnBoardsLengths = new List<CuttedBoard>();
            CuttedBoard CB;
            bool bFind = false;
            int findedI = 0;
            do
            {
                CB = new CuttedBoard(); // Подготавливаем новую доску
                curBoardLength = boardLength;
                do
                {
                    bFind = false;
                    for (int i = 0; (!bFind) && (i < neededBoards.Count); ++i)
                    {
                        if (neededBoards[i] <= curBoardLength)
                        {
                            curBoardLength -= neededBoards[i];
                            CB.Cutts.Add(neededBoards[i]);
                            bFind = true;
                            findedI = i;
                        }
                    }
                    if (bFind)
                    {
                        neededBoards.RemoveAt(findedI);
                    }
                } while (bFind);
                CB.Mod = curBoardLength;
                returnBoardsLengths.Add(CB);
            } while (neededBoards.Count != 0);

            return returnBoardsLengths;
        }
    }
}
