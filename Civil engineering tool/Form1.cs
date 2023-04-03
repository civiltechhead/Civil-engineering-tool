using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civil_engineering_tool
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        // Labeling
        public int px, max_no=0;
        public Button picked_button;
        public DataGridView GV_public;
        public string test, window_name, chosen_button;
        public Form2 f2 = null;
        public Form3 f3 = null;
        public Form4 f4 = null;
        public Form5 f5 = null;
        public Form6 f6 = null;

        // Critical values
        public int[] foot_type = new int[999];
        public string[] foot_label = new string[999];
        Form[] genframe = new Form[999];

        //count
        int delete_mode = 0;
        public int loaded = 0;
        int count = 0;

        // Save code
        List<string> data_listing = new List<string>();

        //Data listing
        public double[] ID_001 = new double[999];
        public double[] ID_002 = new double[999];
        public double[] ID_003 = new double[999];
        public double[] ID_004 = new double[999];
        public double[] ID_005 = new double[999];
        public double[] ID_006 = new double[999];
        public double[] ID_007 = new double[999];
        public double[] ID_008 = new double[999];
        public double[] ID_009 = new double[999];
        public double[] ID_010 = new double[999];
        public double[] ID_011 = new double[999];
        public double[] ID_012 = new double[999];
        public double[] ID_013 = new double[999];
        public double[] ID_014 = new double[999];
        public double[] ID_015 = new double[999];
        public double[] ID_016 = new double[999];
        public double[] ID_017 = new double[999];
        public double[] ID_018 = new double[999];
        public double[] ID_019 = new double[999];
        public double[] ID_020 = new double[999];
        public double[] ID_021 = new double[999];
        public double[] ID_022 = new double[999];
        public double[] ID_023 = new double[999];
        public double[] ID_024 = new double[999];
        public double[] ID_025 = new double[999];
        public double[] ID_026 = new double[999];
        public double[] ID_027 = new double[999];
        public double[] ID_028 = new double[999];
        public double[] ID_029 = new double[999];
        public double[] ID_030 = new double[999];
        public double[] ID_031 = new double[999];
        public double[] ID_032 = new double[999];
        public double[] ID_033 = new double[999];
        public double[] ID_034 = new double[999];
        public double[] ID_035 = new double[999];
        public double[] ID_036 = new double[999];
        public double[] ID_037 = new double[999];
        public double[] ID_038 = new double[999];
        public double[] ID_039 = new double[999];
        public double[] ID_040 = new double[999];
        public double[] ID_041 = new double[999];
        public double[] ID_042 = new double[999];
        public double[] ID_043 = new double[999];
        public double[] ID_044 = new double[999];
        public double[] ID_045 = new double[999];
        public int[] radioCheck  = new int[999];

        public Form1()
        {
            InitializeComponent();
            instance = this;
            GV_public = test_GV;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            footing_type.Items.Add("Square footing");
            footing_type.Items.Add("Rectangular footing");
            footing_type.Items.Add("Combined footing");
            footing_type.Items.Add("Circular footing");
            footing_type.Items.Add("Continuous footing");

            flp1.AutoScroll = true;
            label1.BackColor = Color.Transparent;

            this.MaximizeBox = false;

            for (int i = 0; i < 999; i++)
            {
                foot_type[i] = 5;
            }
        }

        public void add_new_footing_Click(object sender, EventArgs e)
        {
            if (footing_type.SelectedIndex > -1)
            {
                try
                {
                    Button btn = new Button();
                    int i2;
                    for (i2 = 0; i2 < 999; i2++)
                    {
                        if (i2 == 999)
                        {
                            MessageBox.Show("Reached maximum number of footings");
                        }
                        else if (foot_type[i2] == 5)
                        {
                            break;
                        }
                        else
                        {

                        }
                    }

                    if(loaded == 0)
                    {

                    }
                    else
                    {
                        ID_001[i2] = -1234512345;
                        ID_002[i2] = -1234512345;
                        ID_003[i2] = -1234512345;
                        ID_004[i2] = -1234512345;
                        ID_005[i2] = -1234512345;
                        ID_006[i2] = -1234512345;
                        ID_007[i2] = -1234512345;
                        ID_008[i2] = -1234512345;
                        ID_009[i2] = -1234512345;
                        ID_010[i2] = -1234512345;
                        ID_011[i2] = -1234512345;
                        ID_012[i2] = -1234512345;
                        ID_013[i2] = -1234512345;
                        ID_014[i2] = -1234512345;
                        ID_015[i2] = -1234512345;
                        ID_016[i2] = -1234512345;
                        ID_017[i2] = -1234512345;
                        ID_018[i2] = -1234512345;
                        ID_019[i2] = -1234512345;
                        ID_020[i2] = -1234512345;
                        ID_021[i2] = -1234512345;
                        ID_022[i2] = -1234512345;
                        ID_023[i2] = -1234512345;
                        ID_024[i2] = -1234512345;
                        ID_025[i2] = -1234512345;
                        ID_026[i2] = -1234512345;
                        ID_027[i2] = -1234512345;
                        ID_028[i2] = -1234512345;
                        ID_029[i2] = -1234512345;
                        ID_030[i2] = -1234512345;
                        ID_031[i2] = -1234512345;
                        ID_032[i2] = -1234512345;
                        ID_033[i2] = -1234512345;
                        ID_034[i2] = -1234512345;
                        ID_035[i2] = -1234512345;
                        ID_036[i2] = -1234512345;
                        ID_037[i2] = -1234512345;
                        ID_038[i2] = -1234512345;
                        ID_039[i2] = -1234512345;
                        ID_040[i2] = -1234512345;
                        ID_041[i2] = -1234512345;
                        ID_042[i2] = -1234512345;
                        ID_043[i2] = -1234512345;
                        ID_044[i2] = -1234512345;
                        ID_045[i2] = -1234512345;
                    }

                    foot_label[i2] = footing_label.Text;
                    btn.Location = new System.Drawing.Point(3, 3);
                    btn.Name = Convert.ToString(i2);
                    btn.TabIndex = 0;
                    btn.Text = footing_label.Text;
                    flp1.Controls.Add(btn);
                    genframe[i2] = null;
                    count = count + 1;

                    btn.Click += new EventHandler(btn_Click);

                    if (footing_type.SelectedIndex == 1)
                    {
                        foot_type[i2] = 0;
                    }
                    else if (footing_type.SelectedIndex == 0)
                    {
                        foot_type[i2] = 1;
                    }
                    else if (footing_type.SelectedIndex == 2)
                    {
                        foot_type[i2] = 2;
                    }
                    else if (footing_type.SelectedIndex == 3)
                    {
                        foot_type[i2] = 3;
                    }
                    else if (footing_type.SelectedIndex == 4)
                    {
                        foot_type[i2] = 4;
                    }
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Please select a footing type");
            }
        }

        public void save_btn_Click(object sender, EventArgs e)
        {
            delete_mode = 0;
            delete_final.Visible = false;
            back_button.Visible = false;

            foreach (Control a in this.flp1.Controls.OfType<Button>())
            {
                a.BackColor = Control.DefaultBackColor;
            }

            SaveFileDialog saveDlg = new SaveFileDialog();
            string filename = "";

            saveDlg.Filter = "Civil Engineering Tool File (*.cetf) |*.cetf";
            saveDlg.DefaultExt = "*.cetf";
            saveDlg.Title = "Save file";

            DialogResult retval = saveDlg.ShowDialog();
            if (retval == DialogResult.OK)
            {
                try
                {
                    if(test_GV.Rows.Count > 0)
                    {
                        filename = saveDlg.FileName;
                        this.Text = filename + " - Civil engineering tool";
                        DataTable dt = new DataTable();

                        // Columns
                        DataColumn dc1 = new DataColumn("Footing identification");
                        DataColumn dc2 = new DataColumn("ID_001");
                        DataColumn dc3 = new DataColumn("ID_002");
                        DataColumn dc4 = new DataColumn("ID_003");
                        DataColumn dc5 = new DataColumn("ID_004");
                        DataColumn dc6 = new DataColumn("ID_005");
                        DataColumn dc7 = new DataColumn("ID_006");
                        DataColumn dc8 = new DataColumn("ID_007");
                        DataColumn dc9 = new DataColumn("ID_008");
                        DataColumn dc10 = new DataColumn("ID_009");
                        DataColumn dc11 = new DataColumn("ID_010");
                        DataColumn dc12 = new DataColumn("ID_011");
                        DataColumn dc13 = new DataColumn("ID_012");
                        DataColumn dc14 = new DataColumn("ID_013");
                        DataColumn dc15 = new DataColumn("ID_014");
                        DataColumn dc16 = new DataColumn("ID_015");
                        DataColumn dc17 = new DataColumn("ID_016");
                        DataColumn dc18 = new DataColumn("ID_017");
                        DataColumn dc19 = new DataColumn("ID_018");
                        DataColumn dc20 = new DataColumn("ID_019");
                        DataColumn dc21 = new DataColumn("ID_020");
                        DataColumn dc22 = new DataColumn("ID_021");
                        DataColumn dc23 = new DataColumn("ID_022");
                        DataColumn dc24 = new DataColumn("ID_023");
                        DataColumn dc25 = new DataColumn("ID_024");
                        DataColumn dc26 = new DataColumn("ID_025");
                        DataColumn dc27 = new DataColumn("ID_026");
                        DataColumn dc28 = new DataColumn("ID_027");
                        DataColumn dc29 = new DataColumn("ID_028");
                        DataColumn dc30 = new DataColumn("ID_029");
                        DataColumn dc31 = new DataColumn("ID_030");
                        DataColumn dc32 = new DataColumn("ID_031");
                        DataColumn dc33 = new DataColumn("ID_032");
                        DataColumn dc34 = new DataColumn("ID_033");
                        DataColumn dc35 = new DataColumn("ID_034");
                        DataColumn dc36 = new DataColumn("ID_035");
                        DataColumn dc37 = new DataColumn("ID_036");
                        DataColumn dc38 = new DataColumn("ID_037");
                        DataColumn dc39 = new DataColumn("ID_038");
                        DataColumn dc40 = new DataColumn("ID_039");
                        DataColumn dc41 = new DataColumn("ID_040");
                        DataColumn dc42 = new DataColumn("ID_041");
                        DataColumn dc43 = new DataColumn("ID_042");
                        DataColumn dc44 = new DataColumn("ID_043");
                        DataColumn dc45 = new DataColumn("ID_044");
                        DataColumn dc46 = new DataColumn("ID_045");
                        DataColumn dc47 = new DataColumn("Footing type");
                        DataColumn dc48 = new DataColumn("Footing label");
                        DataColumn dc49 = new DataColumn("Radio check");

                        dt.Columns.Add(dc1);
                        dt.Columns.Add(dc2);
                        dt.Columns.Add(dc3);
                        dt.Columns.Add(dc4);
                        dt.Columns.Add(dc5);
                        dt.Columns.Add(dc6);
                        dt.Columns.Add(dc7);
                        dt.Columns.Add(dc8);
                        dt.Columns.Add(dc9);
                        dt.Columns.Add(dc10);
                        dt.Columns.Add(dc11);
                        dt.Columns.Add(dc12);
                        dt.Columns.Add(dc13);
                        dt.Columns.Add(dc14);
                        dt.Columns.Add(dc15);
                        dt.Columns.Add(dc16);
                        dt.Columns.Add(dc17);
                        dt.Columns.Add(dc18);
                        dt.Columns.Add(dc19);
                        dt.Columns.Add(dc20);
                        dt.Columns.Add(dc21);
                        dt.Columns.Add(dc22);
                        dt.Columns.Add(dc23);
                        dt.Columns.Add(dc24);
                        dt.Columns.Add(dc25);
                        dt.Columns.Add(dc26);
                        dt.Columns.Add(dc27);
                        dt.Columns.Add(dc28);
                        dt.Columns.Add(dc29);
                        dt.Columns.Add(dc30);
                        dt.Columns.Add(dc31);
                        dt.Columns.Add(dc32);
                        dt.Columns.Add(dc33);
                        dt.Columns.Add(dc34);
                        dt.Columns.Add(dc35);
                        dt.Columns.Add(dc36);
                        dt.Columns.Add(dc37);
                        dt.Columns.Add(dc38);
                        dt.Columns.Add(dc39);
                        dt.Columns.Add(dc40);
                        dt.Columns.Add(dc41);
                        dt.Columns.Add(dc42);
                        dt.Columns.Add(dc43);
                        dt.Columns.Add(dc44);
                        dt.Columns.Add(dc45);
                        dt.Columns.Add(dc46);
                        dt.Columns.Add(dc47);
                        dt.Columns.Add(dc48);
                        dt.Columns.Add(dc49);

                        for(int i = 0; i < test_GV.Rows.Count; i++)
                        {
                            dt.Rows.Add();
                            for(int j = 0; j < test_GV.Columns.Count; j++)
                            {
                                dt.Rows[i][j] = test_GV.Rows[i].Cells[j].Value;
                            }
                        }

                        DataSet ds = new DataSet();
                        ds.Tables.Add(dt);
                        ds.WriteXml(@filename);
                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                return;
            }
        }

        public void delete_footing_Click(object sender, EventArgs e)
        {
            delete_mode = 1;
            delete_final.Visible = true;
            back_button.Visible = true;

            foreach (Control a in this.flp1.Controls.OfType<Button>())
            {
                a.BackColor = System.Drawing.Color.Red;
            }
        }

        public void back_button_Click(object sender, EventArgs e)
        {
            delete_mode = 0;
            delete_final.Visible = false;
            back_button.Visible = false;

            foreach (Control a in this.flp1.Controls.OfType<Button>())
            {
                a.BackColor = Control.DefaultBackColor;
            }
        }

        public void load_btn_Click(object sender, EventArgs e)
        {
            delete_mode = 0;
            delete_final.Visible = false;
            back_button.Visible = false;

            foreach (Control a in this.flp1.Controls.OfType<Button>())
            {
                a.BackColor = Control.DefaultBackColor;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            string filename = "";

            openFileDialog.Filter = "Civil Engineering Tool File (*.cetf) |*.cetf";
            openFileDialog.DefaultExt = "*.cetf";
            openFileDialog.Title = "Open file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loaded = 1;
                flp1.Controls.Clear();
                filename = openFileDialog.FileName;
                string fname = System.IO.Path.GetFileNameWithoutExtension(filename);
                this.Text = fname + " - Civil engineering tool";

                // Close all forms except form 1
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Form1")
                    {
                        Application.OpenForms[i].Close();
                    }
                }

                test_GV.Columns.Clear();
                DataSet ds = new DataSet();
                ds.ReadXml(@filename);
                test_GV.DataSource = ds.Tables[0];
                count = test_GV.Rows.Count;

                for (int i2=0; i2 < count+1; i2++)
                {
                    try
                    {
                        String searchValue = Convert.ToString(i2);
                        int rowIndex = -1;
                        foreach (DataGridViewRow row in test_GV.Rows)
                        {
                            if (row.Cells[0].Value.ToString().Equals(searchValue))
                            {
                                rowIndex = row.Index;

                                ID_001[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[1].Value.ToString());
                                ID_002[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[2].Value.ToString());
                                ID_003[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[3].Value.ToString());
                                ID_004[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[4].Value.ToString());
                                ID_005[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[5].Value.ToString());
                                ID_006[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[6].Value.ToString());
                                ID_007[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[7].Value.ToString());
                                ID_008[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[8].Value.ToString());
                                ID_009[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[9].Value.ToString());
                                ID_010[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[10].Value.ToString());
                                ID_011[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[11].Value.ToString());
                                ID_012[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[12].Value.ToString());
                                ID_013[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[13].Value.ToString());
                                ID_014[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[14].Value.ToString());
                                ID_015[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[15].Value.ToString());
                                ID_016[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[16].Value.ToString());
                                ID_017[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[17].Value.ToString());
                                ID_018[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[18].Value.ToString());
                                ID_019[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[19].Value.ToString());
                                ID_020[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[20].Value.ToString());
                                ID_021[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[21].Value.ToString());
                                ID_022[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[22].Value.ToString());
                                ID_023[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[23].Value.ToString());
                                ID_024[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[24].Value.ToString());
                                ID_025[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[25].Value.ToString());
                                ID_026[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[26].Value.ToString());
                                ID_027[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[27].Value.ToString());
                                ID_028[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[28].Value.ToString());
                                ID_029[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[29].Value.ToString());
                                ID_030[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[30].Value.ToString());
                                ID_031[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[31].Value.ToString());
                                ID_032[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[32].Value.ToString());
                                ID_033[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[33].Value.ToString());
                                ID_034[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[34].Value.ToString());
                                ID_035[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[35].Value.ToString());
                                ID_036[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[36].Value.ToString());
                                ID_037[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[37].Value.ToString());
                                ID_038[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[38].Value.ToString());
                                ID_039[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[39].Value.ToString());
                                ID_040[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[40].Value.ToString());
                                ID_041[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[41].Value.ToString());
                                ID_042[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[42].Value.ToString());
                                ID_043[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[43].Value.ToString());
                                ID_044[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[44].Value.ToString());
                                ID_045[rowIndex] = Double.Parse(test_GV.Rows[rowIndex].Cells[45].Value.ToString());
                                radioCheck[rowIndex] = Int32.Parse(test_GV.Rows[rowIndex].Cells[48].Value.ToString());

                                Button btn = new Button();
                                foot_label[rowIndex] = test_GV.Rows[rowIndex].Cells[47].Value.ToString();
                                btn.Location = new System.Drawing.Point(3, 3);
                                btn.Name = Convert.ToString(rowIndex);
                                btn.TabIndex = 0;
                                btn.Text = foot_label[rowIndex];
                                flp1.Controls.Add(btn);
                                genframe[rowIndex] = null;
                                btn.Click += new EventHandler(btn_Click);

                                foot_type[rowIndex] = Int32.Parse(test_GV.Rows[rowIndex].Cells[46].Value.ToString());
                                break;
                            }
                        }
                    }
                    catch { }
                }
            }
        }

        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int footing_code = Convert.ToInt32(btn.Name);
            picked_button = btn;
            px = footing_code;

            if(delete_mode == 0)
            {
                if (foot_type[px] == 0)
                {
                    if (genframe[px] == null)
                    {
                        genframe[px] = new Form2();
                        genframe[px].Show();
                    }
                    else
                    {
                        if (genframe[px].Visible == true)
                        {
                            genframe[px].Focus();
                        }
                        else
                        {
                            genframe[px].Visible = true;
                        }
                    }
                }
                else if (foot_type[px] == 1)
                {
                    if (genframe[px] == null)
                    {
                        genframe[px] = new Form3();
                        genframe[px].Show();
                    }
                    else
                    {
                        if (genframe[px].Visible == true)
                        {
                            genframe[px].Focus();
                        }
                        else
                        {
                            genframe[px].Visible = true;
                        }
                    }
                }
                else if (foot_type[px] == 2)
                {
                    if (genframe[px] == null)
                    {
                        genframe[px] = new Form4();
                        genframe[px].Show();
                    }
                    else
                    {
                        if (genframe[px].Visible == true)
                        {
                            genframe[px].Focus();
                        }
                        else
                        {
                            genframe[px].Visible = true;
                        }
                    }
                }
                else if (foot_type[px] == 3)
                {
                    if (genframe[px] == null)
                    {
                        genframe[px] = new Form5();
                        genframe[px].Show();
                    }
                    else
                    {
                        if (genframe[px].Visible == true)
                        {
                            genframe[px].Focus();
                        }
                        else
                        {
                            genframe[px].Visible = true;
                        }
                    }
                }
                else if (foot_type[px] == 4)
                {
                    if (genframe[px] == null)
                    {
                        genframe[px] = new Form6();
                        genframe[px].Show();
                    }
                    else
                    {
                        if (genframe[px].Visible == true)
                        {
                            genframe[px].Focus();
                        }
                        else
                        {
                            genframe[px].Visible = true;
                        }
                    }
                }
            }
            else
            {
                if(genframe[px] == null)
                {
                    btn.Dispose();
                    foot_type[px] = 5;
                    count = count - 1;

                    String searchValue = Convert.ToString(px);
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in Form1.instance.GV_public.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                        }
                    }
                    if (rowIndex == -1)
                    {

                    }
                    else
                    {
                        test_GV.Rows.RemoveAt(rowIndex);

                        ID_001[px] = -1234512345;
                        ID_002[px] = -1234512345;
                        ID_003[px] = -1234512345;
                        ID_004[px] = -1234512345;
                        ID_005[px] = -1234512345;
                        ID_006[px] = -1234512345;
                        ID_007[px] = -1234512345;
                        ID_008[px] = -1234512345;
                        ID_009[px] = -1234512345;
                        ID_010[px] = -1234512345;
                        ID_011[px] = -1234512345;
                        ID_012[px] = -1234512345;
                        ID_013[px] = -1234512345;
                        ID_014[px] = -1234512345;
                        ID_015[px] = -1234512345;
                        ID_016[px] = -1234512345;
                        ID_017[px] = -1234512345;
                        ID_018[px] = -1234512345;
                        ID_019[px] = -1234512345;
                        ID_020[px] = -1234512345;
                        ID_021[px] = -1234512345;
                        ID_022[px] = -1234512345;
                        ID_023[px] = -1234512345;
                        ID_024[px] = -1234512345;
                        ID_025[px] = -1234512345;
                        ID_026[px] = -1234512345;
                        ID_027[px] = -1234512345;
                        ID_028[px] = -1234512345;
                        ID_029[px] = -1234512345;
                        ID_030[px] = -1234512345;
                        ID_031[px] = -1234512345;
                        ID_032[px] = -1234512345;
                        ID_033[px] = -1234512345;
                        ID_034[px] = -1234512345;
                        ID_035[px] = -1234512345;
                        ID_036[px] = -1234512345;
                        ID_037[px] = -1234512345;
                        ID_038[px] = -1234512345;
                        ID_039[px] = -1234512345;
                        ID_040[px] = -1234512345;
                        ID_041[px] = -1234512345;
                        ID_042[px] = -1234512345;
                        ID_043[px] = -1234512345;
                        ID_044[px] = -1234512345;
                        ID_045[px] = -1234512345;
                        radioCheck[px] = 3;
                    }
                }
                else
                {
                    btn.Dispose();
                    genframe[px].Close();
                    foot_type[px] = 5;
                    genframe[px] = null;
                    count = count - 1;

                    String searchValue = Convert.ToString(px);
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in Form1.instance.GV_public.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                        }
                    }
                    if (rowIndex == -1)
                    {

                    }
                    else
                    {
                        test_GV.Rows.RemoveAt(rowIndex);

                        ID_001[px] = -1234512345;
                        ID_002[px] = -1234512345;
                        ID_003[px] = -1234512345;
                        ID_004[px] = -1234512345;
                        ID_005[px] = -1234512345;
                        ID_006[px] = -1234512345;
                        ID_007[px] = -1234512345;
                        ID_008[px] = -1234512345;
                        ID_009[px] = -1234512345;
                        ID_010[px] = -1234512345;
                        ID_011[px] = -1234512345;
                        ID_012[px] = -1234512345;
                        ID_013[px] = -1234512345;
                        ID_014[px] = -1234512345;
                        ID_015[px] = -1234512345;
                        ID_016[px] = -1234512345;
                        ID_017[px] = -1234512345;
                        ID_018[px] = -1234512345;
                        ID_019[px] = -1234512345;
                        ID_020[px] = -1234512345;
                        ID_021[px] = -1234512345;
                        ID_022[px] = -1234512345;
                        ID_023[px] = -1234512345;
                        ID_024[px] = -1234512345;
                        ID_025[px] = -1234512345;
                        ID_026[px] = -1234512345;
                        ID_027[px] = -1234512345;
                        ID_028[px] = -1234512345;
                        ID_029[px] = -1234512345;
                        ID_030[px] = -1234512345;
                        ID_031[px] = -1234512345;
                        ID_032[px] = -1234512345;
                        ID_033[px] = -1234512345;
                        ID_034[px] = -1234512345;
                        ID_035[px] = -1234512345;
                        ID_036[px] = -1234512345;
                        ID_037[px] = -1234512345;
                        ID_038[px] = -1234512345;
                        ID_039[px] = -1234512345;
                        ID_040[px] = -1234512345;
                        ID_041[px] = -1234512345;
                        ID_042[px] = -1234512345;
                        ID_043[px] = -1234512345;
                        ID_044[px] = -1234512345;
                        ID_045[px] = -1234512345;
                        radioCheck[px] = 3;
                    }
                }
            }
        }


    }
}
