using System.Diagnostics;
using System.Text.Json;
using System.Text;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace WinFormsApp8
{

    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Form2()
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
            if (richTextBox1.Text == "Описание...")
            {
                richTextBox1.Text = string.Empty;
            }
        }

        private void TBox_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Описание...";
            }
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            label3.Text = "Качване на снимка...";
            using (var multipartFormContent = new MultipartFormDataContent())
            {
                HttpClient client = new();
                var fstreamContent = new StreamContent(File.OpenRead(richTextBox2.Text));
                fstreamContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                multipartFormContent.Add(fstreamContent, name: "file", fileName: Path.GetFileName(richTextBox2.Text));
                var response = await client.PostAsync("http://play.dejacraft.uk:3000/upload", multipartFormContent);
                response.EnsureSuccessStatusCode();
                string rsp = await response.Content.ReadAsStringAsync();
                JsonDocument jsondoc = JsonDocument.Parse(rsp);
                JsonElement jel = new();
                if (jsondoc.RootElement.TryGetProperty("filename", out jel))
                {
                    string api = "r8_CpEV9rxO6YDK6DZm7UIdU5RpEBg5zLs30irHq";
                    string aurl = "https://api.replicate.com/v1/predictions";
                    string prompt = richTextBox1.Text;
                    client.DefaultRequestHeaders.Add("Authorization", "Token " + api);
                    string jsonPayload = $@"{{
                        ""version"": ""a3d3e0bdeea4925a873179e55701e1091e4b4d7ddeee9a205b932d9de1d9f181"",
                        ""input"": {{
                            ""image"": ""https://images.dejacraft.uk/{jel.GetString()}"",
                            ""prompt"": ""{prompt}"",
                            ""scheduler"": ""K_EULER_ANCESTRAL"",
                            ""num_samples"": 1,
                            ""guidance_scale"": 7.5,
                            ""negative_prompt"": ""anime, cartoon, graphic, text, painting, crayon, graphite, abstract, glitch, deformed, mutated, ugly, disfigured"",
                            ""num_inference_steps"": 30,
                            ""adapter_conditioning_scale"": 0.8,
                            ""adapter_conditioning_factor"": 1
                        }}
                    }}";
                    label3.Text = "Пускане на заявка";
                    HttpContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    response = await client.PostAsync(aurl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        jsondoc = JsonDocument.Parse(res);
                        if (jsondoc.RootElement.TryGetProperty("urls", out JsonElement urlsProperty))
                        {
                            if (urlsProperty.TryGetProperty("get", out JsonElement getUrlProperty))
                            {
                                label3.Text = "Генериране";
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
                                    if (jsondoc2.RootElement.TryGetProperty("status", out JsonElement rspb))
                                    {
                                        status = rspb.GetString();
                                    }
                                }
                                if (jsondoc2.RootElement.TryGetProperty("output", out JsonElement rspe))
                                {
                                    int index = 1;
                                    string url = "";
                                    foreach (JsonElement el in rspe.EnumerateArray())
                                    {
                                        switch (index)
                                        {
                                            case 1:
                                                break;
                                            case 2:
                                                url = el.GetString();
                                                pictureBox1.Load(url);
                                                break;
                                        }
                                        index++;
                                    }
                                }
                                label3.Text = "Пауза";
                                button2.Enabled = true;
                                button1.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Грешка");
                        Debug.WriteLine(await response.Content.ReadAsStringAsync());
                        button2.Enabled = true;
                        label3.Text = "Грешка";
                        button1.Enabled = true;
                    }
                }
                else
                {
                    Debug.WriteLine("Error uploading image!");
                    label3.Text = "Грешка";
                    button2.Enabled = true;
                    button1.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox2.Text = openFileDialog.FileName;
                }
            }
        }

        private void f2_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new();
            f1.closeForms();
        }
    }
}
