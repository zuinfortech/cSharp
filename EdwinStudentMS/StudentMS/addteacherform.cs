using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS
{
    public partial class addteacherform : Form
    {
        public addteacherform()
        {
            InitializeComponent();
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentMSDataSet);

        }

        private void addteacherform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMSDataSet.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.studentMSDataSet.teacher);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
