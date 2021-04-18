using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Object.Text))
            {
                txt_Object.BackColor = Color.White;
                Type t = Type.GetType(txt_Object.Text);
                if(t != null)
                {
                    ctors(t);
                    props(t);
                    methods(t);
                }

                else
                {
                    MessageBox.Show($"{txt_Object.Text} aramış olduğunuz sınıf bulunamadı", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("lütfen bilgi almak istediğiniz sınıfın tam adını giriniz", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Object.BackColor = Color.Yellow;
            }
        }

        private void methods(Type t)
        {
            lst_methods.Items.Clear();
           MethodInfo[] rv =t.GetMethods();
            foreach(var item in rv)
            {
                lst_methods.Items.Add($"{item.ReflectedType.Name} {item.Name}");
            }
        }

        private void props(Type t)
        {
            lst_props.Items.Clear();
           PropertyInfo[] rv =t.GetProperties();
            foreach(var item in rv)
            {
                lst_props.Items.Add(item.Name);
            }
        }

        private void ctors(Type t)
        {
            lst_ctors.Items.Clear();
           ConstructorInfo[] rv= t.GetConstructors();
            foreach(var item in rv)
            {
                lst_ctors.Items.Add(item.ToString());
            }
        }


    }
}
