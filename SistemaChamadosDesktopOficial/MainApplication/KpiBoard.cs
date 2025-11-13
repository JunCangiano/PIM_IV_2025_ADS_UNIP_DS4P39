using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using SistemaChamados.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaChamadosDesktopOficial.MainApplication
{
    public partial class KpiBoard : UserControl
    {
        private readonly TicketService _ticketService = new(); // Serviço para acessar dados de chamados
        public KpiBoard()
        {
            InitializeComponent();
            LoadAllCharts();       // Carrega todos os gráficos do painel KPI ao iniciar
        }
        // Carrega todos os gráficos disponíveis
        private void LoadAllCharts()
        {
            LoadPriorityChart();       // Gráfico de chamados por prioridade
            LoadStatusChart();         // Gráfico de chamados por status
            LoadOpenedPerDayChart();   // Gráfico de chamados abertos por dia
            LoadTechnicianChart();     // Gráfico de chamados por responsável
        }

        /* ---------------- Priority (Bar) ----------------
        Gráfico de barras mostrando quantidade de chamados por prioridade.
        */
        private void LoadPriorityChart()
        {
            DataTable dt = _ticketService.GetTicketsByPriority(); // Retorna colunas: Prioridade, Total

            var model = new PlotModel { Title = "Chamados por Prioridade" };

            // Eixo das categorias (Prioridade) na vertical
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                IsTickCentered = true,
                Angle = 0,
                GapWidth = 0.5
            };

            // Eixo de valores (quantidade) na horizontal
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Total"
            };

            var series = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };

            // Preenche categorias e valores do gráfico
            foreach (DataRow row in dt.Rows)
            {
                string prioridade = row["Prioridade"].ToString();
                int total = Convert.ToInt32(row["Total"]);
                categoryAxis.Labels.Add(prioridade);
                series.Items.Add(new BarItem { Value = total });
            }

            model.Series.Add(series);
            model.Axes.Add(valueAxis);
            model.Axes.Add(categoryAxis);

            plotTicketsByPriority.Model = model;
            plotTicketsByPriority.InvalidatePlot(true);
        }

        /* ---------------- Status (Pie) ----------------
        Gráfico de pizza mostrando distribuição de chamados por status.
        */
        private void LoadStatusChart()
        {
            DataTable dt = _ticketService.GetTicketsByStatus(); // Retorna colunas: Status, Total

            var model = new PlotModel { Title = "Chamados por Status" };
            var pie = new PieSeries
            {
                StrokeThickness = 0,
                InsideLabelPosition = 0.6,
                AngleSpan = 360,
                StartAngle = 0
            };

            foreach (DataRow row in dt.Rows)
            {
                string status = row["Status"].ToString();
                int total = Convert.ToInt32(row["Total"]);
                pie.Slices.Add(new PieSlice(status, total) { IsExploded = false });
            }

            model.Series.Add(pie);
            plotTicketsByStatus.Model = model;
            plotTicketsByStatus.InvalidatePlot(true);
        }

        /* ---------------- Opened per day (Line) ----------------
        Gráfico de linha mostrando quantidade de chamados abertos nos últimos N dias.
        Espera colunas: Dia (data), Total.
        */
        private void LoadOpenedPerDayChart(int days = 30)
        {
            DataTable dt = _ticketService.GetTicketsOpenedPerDay(days); // Dia, Total

            var model = new PlotModel { Title = $"Chamados abertos (últimos {days} dias)" };

            var dateAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Angle = 45 // Rotaciona rótulos para melhor visualização
            };

            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Title = "Total" };

            var series = new LineSeries { MarkerType = MarkerType.Circle };

            foreach (DataRow row in dt.Rows)
            {
                var date = Convert.ToDateTime(row["Dia"]);
                int total = Convert.ToInt32(row["Total"]);
                dateAxis.Labels.Add(date.ToString("dd/MM"));
                series.Points.Add(new DataPoint(dateAxis.Labels.Count - 1, total));
            }

            model.Axes.Add(dateAxis);
            model.Axes.Add(valueAxis);
            model.Series.Add(series);

            plotTicketsOpenedPerDay.Model = model;
            plotTicketsOpenedPerDay.InvalidatePlot(true);
        }

        /* ---------------- Tickets by Technician (Bar) ----------------
        Gráfico de barras mostrando quantidade de chamados por responsável/técnico.
        */
        private void LoadTechnicianChart()
        {
            DataTable dt = _ticketService.GetTicketsByTechnician(); // Responsavel, Total

            var model = new PlotModel { Title = "Chamados por Responsável" };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                IsTickCentered = true,
                Angle = 0
            };

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Title = "Total" };

            var series = new BarSeries { LabelPlacement = LabelPlacement.Inside, LabelFormatString = "{0}" };

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Responsavel"].ToString();
                int total = Convert.ToInt32(row["Total"]);
                categoryAxis.Labels.Add(name);
                series.Items.Add(new BarItem { Value = total });
            }

            model.Series.Add(series);
            model.Axes.Add(valueAxis);
            model.Axes.Add(categoryAxis);

            plotTicketsByTechnician.Model = model;
            plotTicketsByTechnician.InvalidatePlot(true);
        }
    }
}
