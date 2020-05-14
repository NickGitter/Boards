using CutBoards.Statistic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CutBoards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            List<double> l = new List<double>();
            for (int i = 0; i < dgvInput.Rows.Count; ++i)
            {
                if (dgvInput.Rows[i] == null || dgvInput.Rows[i].Cells[0].Value == null || dgvInput.Rows[i].Cells[1].Value == null)
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < int.Parse((dgvInput.Rows[i].Cells[1].Value.ToString())); ++j)
                    {
                        l.Add(double.Parse((dgvInput.Rows[i].Cells[0].Value.ToString().Replace(".",","))) );
                    }
                }
            }

            List<CuttedBoard> CB = StrategyHolder.GetStrategyByName("Сортировка по убыванию").CutBoard(double.Parse(txtStandartBoardLength.Text.Replace(".",",")), l);

            StatisticManagerTotalModAndEffectiveBoardCount statisticManager = new StatisticManagerTotalModAndEffectiveBoardCount();

            StatisticDataTotalModAndEffectiveBoardCount statisticData = (StatisticDataTotalModAndEffectiveBoardCount)statisticManager.AnalyzeCuttedBoards(CB);


            ////////////////////////
            dgvOutput.Rows.Clear();

            for (int i = 0; i < CB.Count; ++ i)
            {
                dgvOutput.Rows.Add();
                dgvOutput.Rows[i].Cells[0].Value = (i + 1).ToString();
                string cutted = "";
                for (int j = 0; j < CB[i].Cutts.Count; ++j)
                {
                    if (j != 0)
                        cutted += " / ";
                    cutted += CB[i].Cutts[j].ToString();

                }
                dgvOutput.Rows[i].Cells[1].Value = cutted;
                dgvOutput.Rows[i].Cells[2].Value = CB[i].Mod;
            }

            ////////////////////////

            lblBoardsCountToBuy.Text = CB.Count.ToString();
            lblTotalMod.Text = statisticData.Mod.ToString();
        }
    }
}
