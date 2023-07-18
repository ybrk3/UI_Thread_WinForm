using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class welcomeWindow : Form
    {
        public welcomeWindow(string username)
        {
            InitializeComponent();
            lbl_welcome.Text = $"Welcome {username} !!";
        }

        private async void btn_cooking_Click(object sender, EventArgs e)
        {
            var sw= Stopwatch.StartNew();
            var preparationOfEggsGroup = await CrackEggs()
                .ContinueWith(async _ =>
                {
                    await ScrambleEggs();
                    await AddSaltOverEggs();
                });

            var preparationOfOvenGroup = await FireOven()
                .ContinueWith(async _ =>
                {
                    await PutPan();
                   await CookEggs();
                   
                });

            await Task.WhenAll(preparationOfEggsGroup,preparationOfOvenGroup);
            await Serve();
            sw.Stop();
            Task.Delay(1000).Wait();
            AddLog($"You prepared eggs in {sw.ElapsedMilliseconds} MS");
        }

        private void AddLog(string logtxt = "")
        {
            //Forma gelen talebin farklı bir iş parçacığından gelip gelmediğini kontrol eder
            
            if (logList.InvokeRequired)
            {
                //Gelen talep async thread'den geldiği için "cross-thread"i önlemek adına Invoke üzerinden çağırılı.
                logList.Invoke(new Action(() => { AddLog(logtxt); }));
                //Başka thread'den UI'a gelen thread Invoke edildikten sonra devam etmemesi adına bu gruptan çıkılır.
                return;
            }

            //Bu blok UI thread'den gelmesi durumunda tekrar çalışacak
            if(!string.IsNullOrEmpty(logtxt))
                logtxt = $"[{DateTime.Now:dd:MM.yyyy HH:mm:ss}] - {logtxt}";


            logList.Items.Add(logtxt);
            logList.TopIndex= logList.Items.Count-1; //Locate last row

        }

        private async Task CrackEggs()
        {
            await Task.Delay(350); //it take 350 ms., then it will log end of the action
            AddLog("Eggs are cracked");
        }
        private async Task ScrambleEggs()
        {
            await Task.Delay(1000); //it take 500 ms., then it will log end of the action
            AddLog("Eggs are scrambled");
        }
        private async Task AddSaltOverEggs()
        {
            await Task.Delay(150); //it take 150 ms., then it will log end of the action
            AddLog("Salt added");
        }
        private async Task FireOven()
        {
            await Task.Delay(1500); //it take 1500 ms., then it will log end of the action
            AddLog("Oven fired");
        }
        private async Task PutPan()
        {
            await Task.Delay(1500); //it take 1500 ms., then it will log end of the action
            AddLog("Pan put on fire");
        }
        private async Task CookEggs()
        {
            await Task.Delay(2000); //it take 2000 ms., then it will log end of the action
            AddLog("Cooking eggs done");
        }
        private async Task Serve()
        {
            await Task.Delay(1000); //it take 1000 ms., then it will log end of the action
            AddLog("Service Done");
        }
    }
}
