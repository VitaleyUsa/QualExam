using Microsoft.Win32;

using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace QualExam
{
    public partial class MainForm : Form
    {
        #region Список доступных url-ов и разрешенного софта

        private const string url_contest = "193.35.100.35 contest.eisnot.ru";

        private const string url_cvalexam = "193.35.100.35 cvalexam.eisnot.ru";

        private const string url_test_contest = "193.35.100.35 test-contest.eisnot.ru";

        private const string url_test_cvalexam = "193.35.100.35 test-cvalexam.eisnot.ru";

        private readonly string[] whitelist = { "QualExam.exe", "Opera.exe", "Firefox.exe", "Browser.exe", "Chrome.exe", "iexplore.exe", "msedge.exe" };

        #endregion Список доступных url-ов и разрешенного софта

        #region Поля для реестра

        private const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
        private const string subkey_mmc = "Software\\Policies\\Microsoft\\MMC";
        private const string subkey_usb = "Software\\Policies\\Microsoft\\Windows\\RemovableStorageDevices";
        private const string valueName = "RestrictRun";
        private const string valueName_mmc = "RestrictAuthorMode";
        private const string valueName_usb = "Deny_All";
        private static string userRoot;
        private string keyName { get; set; }
        private string keyName_mmc { get; set; }
        private string keyName_usb { get; set; }
        private string sid { get; set; }

        #endregion Поля для реестра

        #region Поля для внешнего вида

        public Brush Border_color { get; private set; } = Brushes.Red;

        private Brush Border_colorN { get; set; } = Brushes.Red;

        private Brush Border_colorP { get; set; } = Brushes.Red;

        private Brush Border_colorU { get; set; } = Brushes.Red;

        #endregion Поля для внешнего вида

        #region Поля для сетевых параметров

        // Проверка текущего днс - сервера: 127.0.0.1?
        private static bool Network_loop { get; set; }

        #endregion Поля для сетевых параметров

        #region Конструктор

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Конструктор

        #region Загрузка главной формы

        private void MainForm_Load(object sender, EventArgs e)
        {
            FindSid();
            GetExistingDNS();
            MakeGroupPainEvents();

            Thread SiteAvailThread = new Thread(SiteAvail)
            {
                IsBackground = true
            };

            SiteAvailThread.Start();
        }

        #endregion Загрузка главной формы

        #region Кнопки

        private void Btn_network_default_Click(object sender, EventArgs e)
        {
            Network_loop = false;
            HostsWriter(false);

            if (Properties.Settings.Default.DHCP != false) SetDnsToAuto();
            else
                if (Properties.Settings.Default.DNS2 != "")
            {
                SetDNS(Properties.Settings.Default.DNS1 + "," + Properties.Settings.Default.DNS2);
            }
            else
            {
                SetDNS(Properties.Settings.Default.DNS1);
            }

            Border_colorN = Brushes.Red;
            group_network.Invalidate();
        }

        private void Btn_network_start_Click(object sender, EventArgs e)
        {
            Network_loop = true;

            SetDNS("127.0.0.1");
            HostsWriter(true);

            Border_colorN = Brushes.Green;
            group_network.Invalidate();
        }

        private void Btn_politics_default_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);

                RegistryKey users = Registry.Users;
                RegistryKey userSubkey = users.OpenSubKey(sid, true);

                using (RegistryKey key = userSubkey.OpenSubKey(subkey, true))
                    if (key.SubKeyCount >= 1) key.DeleteSubKeyTree("RestrictRun");

                Border_colorP = Brushes.Red;
                group_politics.Invalidate();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void Btn_politics_start_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                Registry.SetValue(keyName, valueName, 1, RegistryValueKind.DWord);
                Registry.SetValue(keyName + "\\RestrictRun", "", "");
                foreach (string name in whitelist)
                {
                    Registry.SetValue(keyName + "\\RestrictRun", i.ToString(), name, RegistryValueKind.String);
                    i++;
                }

                Border_colorP = Brushes.Green;
                group_politics.Invalidate();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void Btn_usb_default_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(keyName_usb, valueName_usb, 0, RegistryValueKind.DWord);
                Registry.SetValue(keyName_mmc, valueName_mmc, 0, RegistryValueKind.DWord);

                Border_colorU = Brushes.Red;
                group_usb.Invalidate();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error in Btn_usb_default_Click: " + exc.Message);
            }
        }

        private void Btn_usb_start_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(keyName_usb, valueName_usb, 1, RegistryValueKind.DWord);
                Registry.SetValue(keyName_mmc, valueName_mmc, 1, RegistryValueKind.DWord);

                Border_colorU = Brushes.Green;
                group_usb.Invalidate();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error in Btn_usb_start_Click: " + exc.Message);
            }
        }

        #endregion Кнопки

        #region Раздел с ссылками на инструкции

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fciit.ru/files/proc_admin.pdf");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fciit.ru/files/proc_secret.pdf");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fciit.ru/files/proc_qual.pdf");
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fciit.ru/files/con_proc.pdf");
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fciit.ru/files/con_secret.pdf");
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fciit.ru/files/con_admin.pdf");
        }

        #endregion Раздел с ссылками на инструкции

        #region Методы поиска / настройки сети

        private static NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            NetworkInterface[] networks = NetworkInterface.GetAllNetworkInterfaces();

            var activeAdapter = networks.First(x => x.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || x.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                                && x.NetworkInterfaceType != NetworkInterfaceType.Loopback
                                && x.NetworkInterfaceType != NetworkInterfaceType.Tunnel
                                && x.OperationalStatus == OperationalStatus.Up
                                && x.Name.StartsWith("vEthernet") == false
                                && x.NetworkInterfaceType != NetworkInterfaceType.Unknown
                                && x.NetworkInterfaceType != NetworkInterfaceType.Ppp
                                && !x.Description.Contains("TAP-Windows Adapter V9")
                                && !x.Description.Contains("WireGuard"));

            Properties.Settings.Default.Adapter = activeAdapter.Name;
            Properties.Settings.Default.Save();

            IPInterfaceProperties adapterProperties = activeAdapter.GetIPProperties();
            IPAddress ipAddress = adapterProperties.UnicastAddresses
                .Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(addr => addr.Address)
                .FirstOrDefault();

            return activeAdapter;
            //var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
            //    a => a.OperationalStatus == OperationalStatus.Up &&
            //    (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
            //    a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

            //return Nic;
        }

        private static void GetExistingDNS()
        {
            NetworkInterface[] networks = NetworkInterface.GetAllNetworkInterfaces();

            var activeAdapter = GetActiveEthernetOrWifiNetworkInterface();

            IPInterfaceProperties adapterProperties = activeAdapter.GetIPProperties();
            IPAddress ipAddress = adapterProperties.UnicastAddresses
                .Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(addr => addr.Address)
                .FirstOrDefault();

            IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
            IPAddressCollection dhcpServerAddresses = adapterProperties.DhcpServerAddresses;

            Process process = new Process();
            process.StartInfo.FileName = "netsh";
            process.StartInfo.Arguments = $"interface ipv4 show dnsservers \"{activeAdapter.Name}\"";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            int i = 0;

            if (output.Contains("DHCP:"))
            {
                Debug.WriteLine("Активный адаптер использует динамический DNS через DHCP.");
                Properties.Settings.Default.DHCP = true;
            }
            else
            {
                foreach (IPAddress dns in dnsServers)
                {
                    if (dns.ToString() != "127.0.0.1")
                    {
                        if (i == 0) Properties.Settings.Default.DNS1 = dns.ToString();
                        if (i == 1) Properties.Settings.Default.DNS2 = dns.ToString();
                    }
                    else
                    {
                        Network_loop = true;
                    }

                    i++;
                }
            }

            Properties.Settings.Default.Save();
        }

        public static void SetDnsToAuto()
        {
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null)
            {
                Console.WriteLine("Активный интерфейс не найден.");
                return;
            }

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Description"].ToString() == CurrentInterface.Description)
                    {
                        // Попытка включить автоматическое получение DNS через DHCP.
                        objMO.InvokeMethod("SetDNSServerSearchOrder", null);
                        objMO.InvokeMethod("EnableDHCP", null);
                        Console.WriteLine("DNS установлен на автоматическое получение через DHCP.");
                        return;
                    }
                }
            }

            Console.WriteLine("Не удалось установить DNS на автоматическое получение.");
        }

        private static void SetDNS(string DnsString)
        {
            string[] Dns = DnsString.Split(',');
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }

        // Проверка доступности сайтов
        public static bool IsWebsiteAccessible(string url)
        {
            try
            {
                // Создаем HTTP-запрос.
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://npso66.ru");

                request.Timeout = 3000;
                request.Method = "HEAD";

                //Получаем ответ от сервера.
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Проверяем статус ответа.
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Код 200 означает, что веб-сайт доступен.
                        return true;
                    }
                }
            }
            catch (WebException ex)
            {
                // Перехватываем исключение и выводим дополнительную информацию об ошибке.
                Console.WriteLine($"Ошибка при проверке доступности веб-сайта: {ex.Message}");
                if (ex.Response != null)
                {
                    HttpWebResponse errorResponse = (HttpWebResponse)ex.Response;
                    Console.WriteLine($"Статус ошибки: {errorResponse.StatusCode}");
                }
                return false;
            }

            // Если не удалось подтвердить доступность веб-сайта, считаем его недоступным.
            return false;
        }

        // В отдельном потоке для каждого сайта делаем проверку
        private void SiteAvail()
        {
            if (IsWebsiteAccessible(label_test_contest.Text))
                label_test_contest.BeginInvoke((MethodInvoker)(() => this.label_test_contest.Text += " -> Доступен"));
            else
                label_test_contest.BeginInvoke((MethodInvoker)(() => this.label_test_contest.Text += " -> Недоступен"));

            if (IsWebsiteAccessible(label_contest.Text))
                label_contest.BeginInvoke((MethodInvoker)(() => this.label_contest.Text += " -> Доступен"));
            else
                label_contest.BeginInvoke((MethodInvoker)(() => this.label_contest.Text += " -> Недоступен"));

            if (IsWebsiteAccessible(label_test_cvalexam.Text))
                label_test_cvalexam.BeginInvoke((MethodInvoker)(() => this.label_test_cvalexam.Text += " -> Доступен"));
            else
                label_test_cvalexam.BeginInvoke((MethodInvoker)(() => this.label_test_cvalexam.Text += " -> Недоступен"));

            if (IsWebsiteAccessible(label_cvalexam.Text))
                label_cvalexam.BeginInvoke((MethodInvoker)(() => this.label_cvalexam.Text += " -> Доступен"));
            else
                label_cvalexam.BeginInvoke((MethodInvoker)(() => this.label_cvalexam.Text += " -> Недоступен"));
        }

        #endregion Методы поиска / настройки сети

        #region Нахождение sid и запись hosts

        private void FindSid()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            if (identity != null)
            {
                sid = identity.User.Value;

                userRoot = "HKEY_USERS" + "\\" + sid;
                keyName = userRoot + "\\" + subkey;
                keyName_mmc = userRoot + "\\" + subkey_mmc;
                keyName_usb = userRoot + "\\" + subkey_usb;
            }
            else
            {
                // Обработка случая, когда имя пользователя не определено.
                Console.WriteLine("sid not found");
            }
        }

        private void HostsWriter(bool set)
        {
            string path = @"c:\windows\system32\drivers\etc\hosts";
            if (set)
            {
                try
                {
                    if (!System.IO.File.ReadAllLines(path).Contains("193.35.100.35 test-contest.eisnot.ru"))
                    {
                        System.IO.File.Move(path, path + ".backup");

                        string str = string.Empty;

                        str = str.Insert(0, url_test_contest +
                              Environment.NewLine + url_contest +
                              Environment.NewLine + url_test_cvalexam +
                              Environment.NewLine + url_cvalexam +
                              Environment.NewLine);

                        try { System.IO.File.WriteAllText(path, str); }
                        catch (Exception exc) { Console.WriteLine(exc.Message); }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                if (System.IO.File.ReadAllLines(path).Contains("193.35.100.35 test-contest.eisnot.ru"))
                {
                    System.IO.File.Delete(path);
                    System.IO.File.Move(path + ".backup", path);
                }
            }
        }

        #endregion Нахождение sid и запись hosts

        #region Настройка общего вида групбоксов

        private void MakeGroupPainEvents()
        {
            group_politics.Paint += PaintBorderlessGroupBox;
            group_network.Paint += PaintBorderlessGroupBox;
            group_usb.Paint += PaintBorderlessGroupBox;
        }

        // Рисуем границы для groupbox
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Border_color, 5, 0);

            if (box.Name == "group_politics")
            {
                try
                {
                    if (Registry.GetValue(keyName, "RestrictRun", "0").ToString() == "1")
                    {
                        Border_colorP = Brushes.Green;
                        p.Graphics.DrawString(group_politics.Text, group_politics.Font, Border_colorP, 5, 0);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Form_load " + box.Name + " = " + exc);
                }
            }

            if (box.Name == "group_network")
            {
                if (Network_loop)
                {
                    Border_colorN = Brushes.Green;
                    p.Graphics.DrawString(group_network.Text, group_network.Font, Border_colorN, 5, 0);
                }
            }

            if (box.Name == "group_usb")
            {
                try
                {
                    object registryValue = Registry.GetValue(keyName_usb, "Deny_All", "0");

                    if (registryValue != null && registryValue.ToString() == "1")
                    {
                        Border_colorU = Brushes.Green;
                        p.Graphics.DrawString(group_usb.Text, group_usb.Font, Border_colorU, 5, 0);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Form_load " + box.Name + " = " + exc);
                }
            }
        }

        #endregion Настройка общего вида групбоксов
    }
}