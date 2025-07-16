using BarcodeStandard;
using SkiaSharp;
using System.Data;

namespace SG_Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            this.btn_generar.Click += Btn_generar_Click;
            this.btn_print.Click += Btn_print_Click;
            this.txt_Height.KeyPress += Txt_KeyPress;
            this.txt_width.KeyPress += Txt_KeyPress;

            DataTable dtTypes = new DataTable();
            dtTypes.Columns.Add("Id", typeof(int));
            dtTypes.Columns.Add("Type", typeof(string));
            foreach (BarcodeStandard.Type item in Enum.GetValues(typeof(BarcodeStandard.Type)))
            {
                DataRow dr = dtTypes.NewRow();
                dr["Id"] = (int)item;
                dr["Type"] = item.ToString();
                dtTypes.Rows.Add(dr);
            }
            this.cbo_types.DataSource = dtTypes;
            this.cbo_types.DisplayMember = "Type";
            this.cbo_types.ValueMember = "Id";
        }

        private void Txt_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void Btn_generar_Click(object? sender, EventArgs e)
        {
            this.pnl_Barcodes.Controls.Clear();
            int left = 10;
            int top = 10;
            int width = this.pnl_Barcodes.Width;
            
            string[] arrContentCodeBar = this.txtData.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            BarcodeStandard.Type[] types = (BarcodeStandard.Type[])Enum.GetValues(typeof(BarcodeStandard.Type));

            int Id = Convert.ToInt32(this.cbo_types.SelectedValue);
            if (Id == 0)
            {
                MessageBox.Show("Por favor, selecciona un tipo de código");
                return;
            }
            if (this.txt_Height.Text == "" || this.txt_width.Text == "")
            {
                MessageBox.Show("Las propiedades \"Alto\" y \"Ancho\" son obligatorias");
                return;
            }    
            if (this.txtData.Text == "")
            {
                MessageBox.Show("Se requiere al menos un dato para generar los códigos de barras");
                return;
            }

            try
            {
                foreach (string content in arrContentCodeBar)
                {
                    Image img = GenerateBarcode(content, types[Id]);
                    PictureBox pb = new PictureBox();
                    pb.Width = img.Width;
                    pb.Height = img.Height + 30;
                    pb.Image = img;
                    pb.Left = left;
                    pb.Top = top;
                    this.pnl_Barcodes.Controls.Add(pb);
                    left = left + pb.Width + 10;
                    if (left >= width - pb.Width)
                    {
                        top = top + pb.Height + 10;
                        left = 10;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Image GenerateBarcode(string content, BarcodeStandard.Type type)
        {
            Barcode barcode = new Barcode();
            SkiaSharp.SKImage img;
            int width = Convert.ToInt32(this.txt_width.Text);
            int height = Convert.ToInt32(this.txt_Height.Text);
            Image imgBarcode = new Bitmap(width, height);

            try
            {
                barcode.IncludeLabel = true;
                img = barcode.Encode(type, content, new SkiaSharp.SKColorF(0, 0, 0), new SkiaSharp.SKColorF(1.0f, 1.0f, 1.0f), width, height);

                using (SKData data = img.Encode(SKEncodedImageFormat.Png, 100))
                {
                    using (MemoryStream ms = new MemoryStream(data.ToArray()))
                    {
                        imgBarcode = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return imgBarcode;
        }

        private void Btn_print_Click(object? sender, EventArgs e)
        {
            string ruta = "";
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecciona una carpeta:";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Carpeta inicial
                folderBrowserDialog.ShowNewFolderButton = true; // Permite crear nuevas carpetas

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ruta = folderBrowserDialog.SelectedPath;
                    int idx = 1;
                    foreach (var pb in this.pnl_Barcodes.Controls)
                    {
                        if (pb.GetType() == typeof(PictureBox))
                        {
                            PictureBox _pb = (PictureBox)pb;
                            if (_pb.Image != null)
                            {
                                string extension = "png";
                                string rutaImg = Path.Combine(ruta, $"imagen_{idx}.{extension}");
                                _pb.Image.Save(rutaImg);
                                idx++;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó ninguna carpeta.");
                }
            }
        }
    }
}
