using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;

namespace MyWinForm
{
    public partial class Form1 : Form
    {
        static IConfigurationRoot config;
        static Logger logger;
        public Form1()
        {
            InitializeComponent();
            config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            logger = new LoggerConfiguration()
             .WriteTo.File("logs\\" + DateTime.Now.ToString("dd.MM.yyyy") + ".log",
                 outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
             .CreateLogger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = File.ReadAllLines("MyConfig.config");
            lbConfig.Items.Clear();
            foreach (var item in result)
            {
                lbConfig.Items.Add(item);
            }

        }

        string getValueByParam(string paramName)
        {            
            var result = File.ReadAllLines("MyConfig.config");
            foreach (var item in result)
            {
                var split = item.Split('=');
                if (split[0] == paramName)
                {
                    WriteToLog(split[1]);
                    return split[1];
                }
            }
            return "не найдено";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbConfig.Items.Add(getValueByParam(tbParam.Text));            
        }


        void WriteToLog(string paramValue)
        {
            File.AppendAllText("MyLof.log", DateTime.Now.ToString("dd.MM.yyyy") + " - " +  paramValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            lbConfig.Items.Add(config["param1"]);
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            logger.Information("my log info");
            logger.Error("my log error");
            logger.Warning("my log warn");
            logger.Warning("test");
        }
    }
}