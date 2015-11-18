using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Xml.Serialization;
using System.IO;



namespace ProyectoF
{
    
    public partial class Form1 : Form
    {
        public String archnom;
        public int n1 = 5;
        public int n2 = 5;
        public int i;
       
        //public static string InputBox(string Prompt, string Title = "Nombre de Archivo", string DefaultResponse = "", int Xpos = 1, int Ypos = -1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            try {


                archnom = Interaction.InputBox("Nombre del archivo");

                if (String.IsNullOrEmpty(archnom)) {

                    MessageBox.Show("Tienes que ingresar un nombre para el archivo");
                }
                else
                {

                    information info = new information();
                    info.Data1 = tx1.Text;
                    info.Data2 = tx2.Text;
                    info.Data3 = tx3.Text;

                    Save.SaveData(info, archnom);

                    MessageBox.Show("Archivo guardado correctamente.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }//Manda codigo error
        }//Fin de boton salvar

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                string archn = op.FileName;
                MessageBox.Show("Datos cargados correctamente");

                XmlSerializer xs = new XmlSerializer(typeof(information));
                FileStream read = new FileStream(archn, FileMode.Open, FileAccess.Read, FileShare.Read);
                information info = (information)xs.Deserialize(read);
                tx1.Text = info.Data1;
                tx2.Text = info.Data2;
                tx3.Text = info.Data3;
                
               
            
            }

        }

        private void Mas_Click(object sender, EventArgs e)
        {
            

            TextBox txtt = new TextBox();
            txtt.Location = new Point(n1,n2);
            this.Controls.Add(txtt);
            i++;
            
            n2 = n2 + i+20;
            label1.Visible = true;
            label1.Text = Convert.ToString(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxs.NoControlesVacios(this);
        }
    }
}
