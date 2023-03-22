/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;*/

using System;
using System.Text;

using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stuBinary.dat", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.rollno = Convert.ToInt32(txtrollno.Text);
                stu.name = txtstuname.Text;
                stu.percentage = Convert.ToInt32(txtpercentage.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, stu);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stuBinary.dat", FileMode.Open, FileAccess.Read);
                Student dept = new Student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                dept = (Student)binaryFormatter.Deserialize(fs);
                txtrollno.Text = dept.rollno.ToString();
                txtstuname.Text = dept.name;
                txtpercentage.Text = dept.percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stuxml.xml", FileMode.Create, FileAccess.Write);
                Student dept = new Student();
                dept.rollno = Convert.ToInt32(txtrollno.Text);
                dept.name = txtstuname.Text;
                dept.percentage = Convert.ToInt32(txtpercentage.Text);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stuxml.xml", FileMode.Open, FileAccess.Read);
                Student dept = new Student();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                dept = (Student)xmlSerializer.Deserialize(fs);
                txtrollno.Text = dept.rollno.ToString();
                txtstuname.Text = dept.name;
               txtpercentage.Text = dept.percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stusoap.soap", FileMode.Create, FileAccess.Write);
                Student dept = new Student();
                dept.rollno = Convert.ToInt32(txtrollno.Text);
                dept.name = txtstuname.Text;
                dept.percentage = Convert.ToInt32(txtpercentage.Text); 
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\deptsoap.soap", FileMode.Open, FileAccess.Read);
                Student dept = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                dept = (Student)soapFormatter.Deserialize(fs);
                txtrollno.Text = dept.rollno.ToString();
                txtstuname.Text = dept.name;
                txtpercentage.Text = dept.percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stuJson.json", FileMode.Create, FileAccess.Write);
                Student dept = new Student();
                dept.rollno = Convert.ToInt32(txtrollno.Text);
                dept.name = txtstuname.Text;
                dept.percentage = Convert.ToInt32(txtpercentage.Text);
                JsonSerializer.Serialize<Student>(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\stuJson.json", FileMode.Open, FileAccess.Read);
                Student dept = new Student();

                dept = JsonSerializer.Deserialize<Student>(fs);
                txtrollno.Text = dept.rollno.ToString();
                txtstuname.Text = dept.name;
                txtpercentage.Text = dept.percentage.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
