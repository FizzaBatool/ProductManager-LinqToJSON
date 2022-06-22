using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace Linq_To_Json
{
    public partial class ProductForm : System.Web.UI.Page
    {
        List<Dictionary<string, object>> rows;
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Server.MapPath("Products.json"));
            string json = reader.ReadToEnd();
            rows = serializer.Deserialize<List<Dictionary<string, object>>>(json);
            reader.Close();
            if (!IsPostBack)
            {
                txtMain.Text = serializer.Serialize(rows);
            }
            gridView.DataSource = DisplayJsonData();
            gridView.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtId.Text);
            row.Add("P_Title", txtTitle.Text);
            row.Add("P_Price", txtPrice.Text);
            row.Add("P_Expiry", txtExpiry.Text);
            row.Add("P_Manufacturer", txtManufacturer.Text);
            row.Add("P_Stock", txtStock.Text);
            rows.Add(row);
            txtMain.Text = serializer.Serialize(rows);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtId.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            row["P_Title"] = txtTitle.Text;
            row["P_Price"] = txtPrice.Text;
            row["P_Expiry"] = txtExpiry.Text;
            row["P_Manufacturer"] = txtManufacturer.Text;
            row["P_Stock"] = txtStock.Text;
            txtMain.Text = serializer.Serialize(rows);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtId.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            rows.Remove(row);
            txtMain.Text = serializer.Serialize(rows);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("P_ID", txtId.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            txtTitle.Text = row["P_Title"].ToString();
            txtPrice.Text = row["P_Price"].ToString();
            txtExpiry.Text = row["P_Expiry"].ToString();
            txtManufacturer.Text = row["P_Manufacturer"].ToString();
            txtStock.Text = row["P_Stock"].ToString();
        }

        public DataTable DisplayJsonData()
        {
            StreamReader sr = new StreamReader(Server.MapPath("~/Products.json"));
            string json = sr.ReadToEnd();
            sr.Close();
            var table = JsonConvert.DeserializeObject<DataTable>(json);
            return table;
        }

        protected void btnSaveToFile_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter myFile = new System.IO.StreamWriter(Server.MapPath("Products.json"));
            if (!txtMain.Text.Equals(" "))
            {
                myFile.WriteLine(txtMain.Text);
            }
            myFile.Close();
        }
    }
}