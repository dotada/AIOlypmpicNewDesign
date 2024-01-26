using System.Diagnostics;
using System.Text.Json;
using System.Text;

namespace WinFormsApp8
{

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTTI_Click(object sender, EventArgs e)
        {
            /*
            panelLeft.Height = buttonTTI.Height;
            panelLeft.Top = buttonTTI.Top;
            */
        }

        private void buttonSTI_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSTI.Height;
            panelLeft.Top = buttonSTI.Top;
        }

        private void TBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void TBox_Leave(object sender, EventArgs e)
        {
            
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            richTextBox1.ReadOnly = true;
            buttonSTI.Enabled = false;
            buttonTTI.Enabled = false;
            string api = "r8_CpEV9rxO6YDK6DZm7UIdU5RpEBg5zLs30irHq";
            string aurl = "https://api.replicate.com/v1/predictions";
            label3.Text = "Пращане на заявка";
            string text = richTextBox1.Text;
            using (HttpClient client = new())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Token " + api);
                string jsonPayload = $@"{{
                    ""version"": ""ad59ca21177f9e217b9075e7300cf6e14f7e5b4505b87b9689dbd866e9768969"",
                    ""input"": {{
                        ""width"": 512,
                        ""height"": 512,
                        ""prompt"": ""{"mdjrny-v4 style " + text}"",
                        ""scheduler"": ""DPMSolverMultistep"",
                        ""num_outputs"": 1,
                        ""guidance_scale"": 7,
                        ""prompt_strength"": 0.8,
                        ""num_inference_steps"": 50
                    }}
                }}";
                HttpContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(aurl, content);
                if (response.IsSuccessStatusCode)
                {
                    string res = await response.Content.ReadAsStringAsync();
                    label3.Text = "Генериране";
                    JsonDocument jsondoc = JsonDocument.Parse(res);
                    if (jsondoc.RootElement.TryGetProperty("urls", out JsonElement urlsProperty))
                    {
                        if (urlsProperty.TryGetProperty("get", out JsonElement getUrlProperty))
                        {
                            string getUrl = getUrlProperty.GetString();
                            string status = "generating";
                            Thread.Sleep(3000);
                            HttpResponseMessage getres = await client.GetAsync(getUrl);
                            string contente = await getres.Content.ReadAsStringAsync();
                            JsonDocument jsondoc2 = JsonDocument.Parse(contente);
                            while (status != "succeeded")
                            {
                                Thread.Sleep(500);
                                getres = await client.GetAsync(getUrl);
                                contente = await getres.Content.ReadAsStringAsync();
                                jsondoc2 = JsonDocument.Parse(contente);
                                if (jsondoc2.RootElement.TryGetProperty("status", out JsonElement rsp))
                                {
                                    status = rsp.GetString();
                                }
                            }
                            if (jsondoc2.RootElement.TryGetProperty("output", out JsonElement rspe))
                            {
                                foreach (JsonElement el in rspe.EnumerateArray())
                                {
                                    string url = el.GetString();
                                    pictureBox1.LoadAsync(url);
                                }
                            }
                            label3.Text = "Пауза";
                            button1.Enabled = true;
                            richTextBox1.ReadOnly = false;
                            buttonSTI.Enabled = true;
                            buttonTTI.Enabled = true;
                        }
                    }
                }
                else
                {
                    button1.Enabled = true;
                    richTextBox1.ReadOnly = false;
                    buttonSTI.Enabled = true;
                    buttonTTI.Enabled = true;
                    label3.Text = "Грешка";
                    Debug.WriteLine(response.ToString());
                }
            }
        }
    }
}
