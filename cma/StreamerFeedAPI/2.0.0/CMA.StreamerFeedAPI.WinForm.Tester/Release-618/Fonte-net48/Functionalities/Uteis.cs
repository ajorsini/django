using CMA.StreamerFeed.Models.V1.Acceptor;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public static class Uteis
    {
        public static bool GetHealthCheckStatus(WinFormAPITester.frmWinFormAPITester frm)
        {
            HealthCheck resultHealthCheck = new HealthCheck();
            Task taskHealthCheck = Task.Run(() => { resultHealthCheck = frm.cmaStreamerFeed.HealthCheck(false).Result; });
            taskHealthCheck.Wait(10000);
            if (resultHealthCheck.Api.Status == false)
            {
                MessageBox.Show("Conexão com Acceptor/Streamer não inicializada! Verifique as conexões na aba HealthCheck.", "WinFornAPITester - Conexão Acceptor/Streamer", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return resultHealthCheck.Api.Status;
        }
    }
}
