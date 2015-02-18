using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;


namespace Neo4jTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var client = new GraphClient(new Uri(txtURL.Text));
            try
            {
                client.Connect();
                MessageBox.Show("Conectado");
                var query = client.Cypher.Set(txtBoxCypher.Text);
                MessageBox.Show(query.Query.QueryText);
                MessageBox.Show(query.Query.DebugQueryText);

                var results = ((IRawGraphClient)client).ExecuteGetCypherResults<TreeNode>(query.Query).ToList();

                foreach (var rest in results)
                {
                    txtBoxCypher.AppendText(rest.ToString()+ "\n");
                }

            }
            catch ( Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
