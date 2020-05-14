using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutBoards.Statistic
{
    public abstract class StatisticDataBase
    {
    }
    public class StatisticDataTotalModAndEffectiveBoardCount : StatisticDataBase
    {
        public double Mod { get; set; }
        public double MaxEffectiveBoardCount { get; set; }

        public override string ToString()
        {
            return string.Format("Суммарный остаток:{0} Кол-во максимально-эффективных досок:{1}", Mod, MaxEffectiveBoardCount);
        }
    }
    public abstract class StatisticManagerBase
    {
        public abstract StatisticDataBase AnalyzeCuttedBoards(List<CuttedBoard> cuttedBoards);
    }
    public class StatisticManagerTotalModAndEffectiveBoardCount : StatisticManagerBase
    {
        public override StatisticDataBase AnalyzeCuttedBoards(List<CuttedBoard> cuttedBoards)
        {
            StatisticDataTotalModAndEffectiveBoardCount SD = new StatisticDataTotalModAndEffectiveBoardCount();

            SD.Mod = 0;
            SD.MaxEffectiveBoardCount = 0;
            if (cuttedBoards != null)
            {
                foreach (CuttedBoard CB in cuttedBoards)
                {
                    SD.Mod += CB.Mod;
                    if (CB.Mod.MyExt_IsZero())
                        ++SD.MaxEffectiveBoardCount;
                }
            }
            return SD;
        }
    }
}
