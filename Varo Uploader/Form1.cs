using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace Varo_Uploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpClient httpClient = new HttpClient();

        private void adddomainbutton_Click(object sender, EventArgs e)
        {
            if (adddomaintextbox.Text != "")
            {
                adddomain(adddomaintextbox.Text);
                adddomaintextbox.Text = "";
            }
        }
        void adddomain(string domain)
        {
            if (domainlistBox.Items.Contains(domain))
            {
                addlog("Domain already exists");
            }
            else
            {
                domainlistBox.Items.Add(domain);
            }
        }

        private void adddomaintextbox_KeyDown(object sender, KeyEventArgs e)
        {
            // Press add domain if enter pressed
            if (e.KeyCode == Keys.Enter)
            {
                adddomainbutton.PerformClick();
            }
        }

        private void clearlogsbutton_Click(object sender, EventArgs e)
        {
            logtextbox.Text = "";
            
        }
        void addlog(string message)
        {
            logtextbox.Text = logtextbox.Text + message+Environment.NewLine;
        }

        private void importdomainbutton_Click(object sender, EventArgs e)
        {
            // Import domains from .csv
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        adddomain(line);
                    }
                }
            }
        }

        private void deletedomainbutton_Click(object sender, EventArgs e)
        {
            domainlistBox.Items.Remove(domainlistBox.SelectedItem);
        }

        private void hsdmainnetbutton_Click(object sender, EventArgs e)
        {
            hsdurltextBox.Text = "127.0.0.1:12039";
        }

        private void hsdregtestbutton_Click(object sender, EventArgs e)
        {
            hsdurltextBox.Text = "127.0.0.1:14039";
        }

        private void varotestbutton_Click(object sender, EventArgs e)
        {
            addlog("Testing varo api connection");
            // Create a post with API url and api key
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, varourltextBox.Text);

            // Add authorisation header
            request.Headers.Add("Authorization", "Bearer " + varokeytextBox.Text);

            // Use type Content-Type: application/json

            request.Content = new StringContent("{\"action\":\"getInfo\"}",System.Text.Encoding.UTF8,"application/json");

            try
            {

                // Send request
                HttpResponseMessage response = httpClient.SendAsync(request).Result;

                // Get response
                string responseString = response.Content.ReadAsStringAsync().Result;

                // Log results
                addlog(responseString);
                
            }
            catch (Exception ex)
            {
                addlog("Varo API connection failed");
                addlog(ex.Message);

            }
        }

        private async void hsdtestbutton_ClickAsync(object sender, EventArgs e)
        {
            addlog("Testing HSD api connection");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://" + hsdurltextBox.Text + "/wallet/" + hsdwallettextBox.Text + "/account");
            // Add API key to header
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + hsdkeytextBox.Text)));

            try
            {
                // Send request and log response
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                addlog(responseBody);
            }
            // Log errors to log textbox
            catch (Exception error)
            {
                addlog("Error: " + error.Message);
            }
        }

        private void addvarobutton_Click(object sender, EventArgs e)
        {
            addlog("Adding domains via varo api");
            // Create a post with API url and api key
            string[] domains = domainlistBox.Items.OfType<string>().ToArray();
            foreach (string domain in domains) {
                addlog("Adding " + domain);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, varourltextBox.Text);

                // Add authorisation header
                request.Headers.Add("Authorization", "Bearer " + varokeytextBox.Text);

                // Use type Content-Type: application/json
                request.Content = new StringContent("{\"action\":\"createZone\",\"domain\":\"" + domain + "\"}", System.Text.Encoding.UTF8, "application/json");

                try
                {

                    // Send request
                    HttpResponseMessage response = httpClient.SendAsync(request).Result;

                    // Get response
                    string responseString = response.Content.ReadAsStringAsync().Result;

                    // Log results
                    addlog(responseString);
                                        
                }
                catch (Exception ex)
                {
                    addlog("Add domain failed");
                    addlog(ex.Message);
                    return;
                }
            }
        }

        private async void addtobobbutton_ClickAsync(object sender, EventArgs e)
        {
            addlog("Getting varo records");
            // Create a post with API url and api key
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, varourltextBox.Text);

            // Add authorisation header
            request.Headers.Add("Authorization", "Bearer " + varokeytextBox.Text);

            // Use type Content-Type: application/json

            request.Content = new StringContent("{\"action\":\"getZones\"}", System.Text.Encoding.UTF8, "application/json");

            try
            {

                // Send request
                HttpResponseMessage response = httpClient.SendAsync(request).Result;

                // Get response
                string responseString = response.Content.ReadAsStringAsync().Result;

                //get id for name
                dynamic json = JObject.Parse(responseString);

                // Get the data array
                JArray data = (JArray)json["data"];

                // Loop through the array
                foreach (JObject item in data)
                {
                    
                    // Get the name and id
                    string name = (string)item["name"];
                    string id = (string)item["id"];

                    if (domainlistBox.Items.Contains(name))
                    {
                        // Log the name and id
                        addlog("Name: " + name + " ID: " + id);
                        HttpRequestMessage zonerequest = new HttpRequestMessage(HttpMethod.Post, varourltextBox.Text);

                        // Add authorisation header
                        zonerequest.Headers.Add("Authorization", "Bearer " + varokeytextBox.Text);

                        // Use type Content-Type: application/json

                        zonerequest.Content = new StringContent("{\"action\":\"showZone\",\"zone\":\"" + id + "\",\"staked\":false}", System.Text.Encoding.UTF8, "application/json");
                        // Send request
                        HttpResponseMessage zonerequestresponse = httpClient.SendAsync(zonerequest).Result;

                        // Get response
                        string zonerequeststring = zonerequestresponse.Content.ReadAsStringAsync().Result;

                        dynamic jsonzone = JObject.Parse(zonerequeststring);

                        // Get the data object
                        JObject datazone = (JObject)jsonzone["data"];

                        // Get the NS array
                        JArray nsdata = (JArray)datazone["NS"];

                        // Get ns as string[]

                        string[] nsarray = nsdata.ToObject<string[]>();

                        foreach (string ns in nsarray)
                        addlog("NS " + ns);

                        // Get DS record
                        string ds = (string)datazone["DS"];

                        addlog("DS " + ds);
                        string[] dsinfo = ds.Split(' ');

                        string keytag = dsinfo[0];
                        string algorithm = dsinfo[1];
                        string digesttype = dsinfo[2];
                        string digest = dsinfo[3];



                        // Send update
                        addlog("Sending update to bob");
                        string updatedata = @"{""passphrase"":"""+hsdpasswordtextBox.Text + @""",""name"":""" + name + @""",""broadcast"":true,""sign"":true,""data"": {""records"": [ {""type"": ""NS"", ""ns"": """ + nsarray[0] + @"""},{""type"": ""NS"", ""ns"": """ + nsarray[1] + @"""},{""type"": ""DS"",""keyTag"": "+keytag+ @",""algorithm"": " + algorithm + @",""digesttype"": " + digesttype + @",""digest"": """ + digest + @"""}]}}";
                        addlog(updatedata);
                        
                        HttpRequestMessage bobrequest = new HttpRequestMessage(HttpMethod.Post, "http://" + hsdurltextBox.Text + "/wallet/" + hsdwallettextBox.Text + "/update");

                        // Add API key to header
                        bobrequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + hsdkeytextBox.Text)));

                        bobrequest.Content = new StringContent(updatedata);
                        

                        HttpResponseMessage bobresponse = await httpClient.SendAsync(bobrequest);
                        string responseBody = await bobresponse.Content.ReadAsStringAsync();
                        addlog(responseBody);
                        bobresponse.EnsureSuccessStatusCode();
                        addlog("Sent update");
                        

                    }


                }


            }
            catch (Exception ex)
            {
                
                addlog("Error "+ex.Message);

            }
        }
    }
}
