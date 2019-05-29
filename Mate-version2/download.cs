using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Upgrade_dll;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace Mate_version2
{
    class download
    {
        Timer time = new Timer();
        string completo;

        internal string kontrola(string[] preklad, string verze, string produkt, bool full)
        {
            completo = preklad[5];
            try
            {
                if (Upgrade.Najdi(verze, produkt) == true)
                {
                    if (full == true)
                    {
                        dotaz quest = new dotaz();
                        quest.Title.Text = preklad[1];
                        quest.label1.Text = preklad[2];
                        quest.Yes.Text = preklad[3];
                        quest.No.Text = preklad[4];
                        quest.ShowDialog();
                        if (quest.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            return "Stahuji!";
                        }
                        else
                        {
                            return "end";
                        }
                    }
                    else
                        return "Stahuji!";
                }
                else
                {
                    if (full == true)
                    {
                        hotovo comp = new hotovo();
                        comp.status.Text = preklad[0];
                        comp.ShowDialog();
                        return "end";
                    }
                    else
                    { return "end"; }
                }
            }
            catch
            {
                return "unreadable";
            }
        }

        public void Download(string produkt)
        {
            WebClient c = new WebClient();
            c.DownloadFileCompleted += new AsyncCompletedEventHandler(c_DownloadFileCompleted);
            Uri u = new Uri("https://dl.dropboxusercontent.com/s/kj3fmuk5rsbybeq/Upgrade.exe?token_hash=AAHfns7PQKeq9fG3GzT0q8BrlS-woGafELBKGUUqD4yxjw&amp;dl=1");
            time.Start();
            c.DownloadFileAsync(u, Environment.CurrentDirectory + "\\upgrade.exe");
        }

        public void c_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            time.Stop();
            hotovo complete = new hotovo();
            complete.status.Text = completo;
            complete.ShowDialog();
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\upgrade.exe");
            }
            catch
            {
                spusti();
            }
        }

        private void spusti()
        {
            try
            {
                System.Diagnostics.Process.Start("upgrade.exe");
            }
            catch
            { spusti(); }
        }
    }
}
