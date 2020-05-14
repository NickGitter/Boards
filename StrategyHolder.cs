using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutBoards
{
    public static class StrategyHolder
    {
        public static Dictionary<string, CutBoardStrategyBase> Strategies { get; private set; } = new Dictionary<string, CutBoardStrategyBase>();

        static StrategyHolder()
        {
            Strategies.Add("Простой", new CutBoardSimpleStrategy());
            Strategies.Add("Сортировка по убыванию", new CutBoardSortedFromHeightToLowStrategy());
            Strategies.Add("Сортировка по возрастанию", new CutBoardSortedFromLowToHeightStrategy());
        }
        public static CutBoardStrategyBase GetStrategyByName(string strategyName)
        {
            if (Strategies.ContainsKey(strategyName))
            {
                return Strategies[strategyName];
            }
            return Strategies["Простой"];
        }
        
    }
}
