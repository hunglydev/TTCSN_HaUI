using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAOQR;

namespace QLSKwinform.VietQRAPI
{
    public partial class ThanhToanForm : Form
    {
        string em;
        public ThanhToanForm(string em, string thanhTien, string diaDiem)
        {
            InitializeComponent();
            this.em = em;
            var apiRequest = new APIRequest();
            apiRequest.acqId = 970422;
            apiRequest.accountNo = long.Parse("5018112003");
            apiRequest.accountName = "Ly Hai Hung";     
                apiRequest.amount = int.Parse(thanhTien);
      
            apiRequest.addInfo ="Thanh toán hóa đơn " + diaDiem;

            apiRequest.template = "compact2";
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            //use resharp to request API
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);

            var content = response.Content;

            var dataResult = JsonConvert.DeserializeObject<APIRespond>(content);

            var img = Base64ToImg(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));

            pictureBox1.Image = img;
        }
        public Image Base64ToImg(string base64String)
        {
            byte[] imgBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms, true);
            return img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(em);
            this.Hide();
            eventForm.ShowDialog();
        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
