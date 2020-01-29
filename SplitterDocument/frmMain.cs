using System;
using System.Windows.Forms;
using System.IO;

namespace SplitterDocument
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private string getPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else return "";
            }
        }

        private byte[] getBytes(string filePath)
        {
            using (FileStream fstream = File.OpenRead(filePath))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                return array;
            }
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {

            tbFileName1.Text = getPath();
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            tbFileName2.Text = getPath();
        }

        private void btnOpenFile3_Click(object sender, EventArgs e)
        {
            tbFileName3.Text = getPath();
        }

        private void btnMerge_Click(object sender, EventArgs e)
 {
            if (tbFileName1.Text.Length < 1 || tbFileName2.Text.Length < 1)
            {
                MessageBox.Show("Выберите файлы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (getBytes(tbFileName1.Text).Length != getBytes(tbFileName2.Text).Length)
            {
                MessageBox.Show("Выберите файлы одинакового размера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbFileName1.Text == tbFileName2.Text)
            {
                if (DialogResult.No == MessageBox.Show("Вы действительно хотите соединить идентичные файлы?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    return;
            }

            Cursor.Current = Cursors.WaitCursor;
            Bytes bytes = new Bytes(getBytes(tbFileName1.Text), getBytes(tbFileName2.Text));
            bytes.mergeMass();

            MessageBox.Show("Выберите путь для сохранения файла", "Выбор файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                using (FileStream fstream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    fstream.Write(bytes.result_mass, 0, bytes.result_mass.Length);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (tbFileName3.Text.Length < 1 )
            {
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (getBytes(tbFileName3.Text).Length % 2 != 0)
            {
                MessageBox.Show("Выберите файл четного размера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            Bytes bytes = new Bytes(getBytes(tbFileName3.Text));
            bytes.SplitMass();

            MessageBox.Show("Выберите путь для сохранения первого файла", "Выбор файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
                openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                using (FileStream fstream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    fstream.Write(bytes.result_mass, 0, bytes.result_mass.Length);
                }
            }

            MessageBox.Show("Выберите путь для сохранения второго файла", "Выбор файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
                using (FileStream fstream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    fstream.Write(bytes.result_mass2, 0, bytes.result_mass2.Length);
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
