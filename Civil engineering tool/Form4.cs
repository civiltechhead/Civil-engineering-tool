using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Civil_engineering_tool
{
    public partial class Form4 : Form
    {
        // COMBINED FOOTING

        public static Form4 instance;
        public int opened_alert_2=0;
        public int defining_id = Form1.instance.px;

        public Form4()
        {
            InitializeComponent();
            instance = this;
        }

        public void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Combined footing: " + Form1.instance.picked_button.Text;
            defining_id = Form1.instance.px;
            area_verify.Visible = false;
            this.MaximizeBox = false;
            this.ControlBox = false;

            if (Form1.instance.loaded == 1)
            {
                col_dimension_1.Text       =  Convert.ToString(Form1.instance.ID_001[defining_id]);
                col_dimension_1_1.Text     =  Convert.ToString(Form1.instance.ID_002[defining_id]);
                col_dimension_2.Text       =  Convert.ToString(Form1.instance.ID_003[defining_id]);
                col_dimension_1_2.Text     =  Convert.ToString(Form1.instance.ID_004[defining_id]);
                footing_T.Text             =  Convert.ToString(Form1.instance.ID_005[defining_id]);
                footing_L.Text             =  Convert.ToString(Form1.instance.ID_006[defining_id]);
                footing_W.Text             =  Convert.ToString(Form1.instance.ID_007[defining_id]);
                footing_D.Text             =  Convert.ToString(Form1.instance.ID_008[defining_id]);
                dead_load.Text             =  Convert.ToString(Form1.instance.ID_009[defining_id]);
                live_load.Text             =  Convert.ToString(Form1.instance.ID_010[defining_id]);
                wind_load.Text             =  Convert.ToString(Form1.instance.ID_011[defining_id]);
                eq_load.Text               =  Convert.ToString(Form1.instance.ID_012[defining_id]);
                roof_load.Text             =  Convert.ToString(Form1.instance.ID_013[defining_id]);
                h_dead_load.Text           =  Convert.ToString(Form1.instance.ID_014[defining_id]);
                h_live_load.Text           =  Convert.ToString(Form1.instance.ID_015[defining_id]);
                h_wind_load.Text           =  Convert.ToString(Form1.instance.ID_017[defining_id]);
                h_eq_load.Text             =  Convert.ToString(Form1.instance.ID_016[defining_id]);
                h_roof_load.Text           =  Convert.ToString(Form1.instance.ID_018[defining_id]);
                v_dead_load_2.Text         =  Convert.ToString(Form1.instance.ID_019[defining_id]);
                v_live_load_2.Text         =  Convert.ToString(Form1.instance.ID_020[defining_id]);
                v_wind_load_2.Text         =  Convert.ToString(Form1.instance.ID_021[defining_id]);
                v_eq_load_2.Text           =  Convert.ToString(Form1.instance.ID_022[defining_id]);
                v_roof_load_2.Text         =  Convert.ToString(Form1.instance.ID_023[defining_id]);
                h_dead_load_2.Text         =  Convert.ToString(Form1.instance.ID_024[defining_id]);
                h_live_load_2.Text         =  Convert.ToString(Form1.instance.ID_025[defining_id]);
                h_wind_load_2.Text         =  Convert.ToString(Form1.instance.ID_027[defining_id]);
                h_eq_load_2.Text           =  Convert.ToString(Form1.instance.ID_026[defining_id]);
                h_roof_load_2.Text         =  Convert.ToString(Form1.instance.ID_028[defining_id]);
                concrete_cover.Text        =  Convert.ToString(Form1.instance.ID_029[defining_id]);
                bar_diameter.Text          =  Convert.ToString(Form1.instance.ID_030[defining_id]);
                diameter_col.Text          =  Convert.ToString(Form1.instance.ID_031[defining_id]);
                temp_bar_col.Text          =  Convert.ToString(Form1.instance.ID_032[defining_id]);
                tie_diameter.Text          =  Convert.ToString(Form1.instance.ID_034[defining_id]);
                ows_phi.Text               =  Convert.ToString(Form1.instance.ID_035[defining_id]);
                ku_phi.Text                =  Convert.ToString(Form1.instance.ID_036[defining_id]);
                position_multi.Text        =  Convert.ToString(Form1.instance.ID_037[defining_id]);
                alpha_value.Text           =  Convert.ToString(Form1.instance.ID_038[defining_id]);
                beta_value.Text            =  Convert.ToString(Form1.instance.ID_039[defining_id]);
                unit_weight_conc.Text      =  Convert.ToString(Form1.instance.ID_040[defining_id]);
                bearing_capacity.Text      =  Convert.ToString(Form1.instance.ID_041[defining_id]);
                strength_fc.Text           =  Convert.ToString(Form1.instance.ID_042[defining_id]);
                tension_fy.Text            =  Convert.ToString(Form1.instance.ID_043[defining_id]);
                edge_dist.Text             =  Convert.ToString(Form1.instance.ID_044[defining_id]);
                dist_btn_cols.Text         =  Convert.ToString(Form1.instance.ID_045[defining_id]);

                if (Form1.instance.radioCheck[defining_id] == 1)
                {
                    spiral_reinf.Checked = true;
                }
                else if (Form1.instance.radioCheck[defining_id] == 2)
                {
                    tie_reinf.Checked = true;
                }

                foreach (Control c in this.groupBox1.Controls.OfType<TextBox>())
                {
                    if (c.Text == Convert.ToString(0) || c.Text == Convert.ToString(-1234512345))
                    {
                        c.Text = "";
                    }
                }
                foreach (Control x in this.tabPage3.Controls.OfType<TextBox>())
                {
                    if (x.Text == Convert.ToString(-1234512345))
                    {
                        x.Text = "";
                    }
                }
                foreach (Control y in this.tabPage4.Controls.OfType<TextBox>())
                {
                    if (y.Text == Convert.ToString(-1234512345))
                    {
                        y.Text = "";
                    }
                }
                foreach (Control y in this.tabPage6.Controls.OfType<TextBox>())
                {
                    if (y.Text == Convert.ToString(-1234512345))
                    {
                        y.Text = "";
                    }
                }
                foreach (Control y in this.tabPage7.Controls.OfType<TextBox>())
                {
                    if (y.Text == Convert.ToString(-1234512345))
                    {
                        y.Text = "";
                    }
                }
            }
        }

        public void calculation_btn_Click(object sender, EventArgs e)
        {
            int menu_1 = 0, menu_2 = 0, menu_3 = 0;

            foreach (Control x in this.tabPage3.Controls.OfType<TextBox>())
            {
                if (double.TryParse(x.Text, out double test8) && Double.Parse(x.Text) >= 0)
                {
                    foreach (Control y in this.tabPage4.Controls.OfType<TextBox>())
                    {
                        if (double.TryParse(y.Text, out double test9) && Double.Parse(y.Text) >= 0)
                        {
                            foreach (Control z in this.tabPage6.Controls.OfType<TextBox>())
                            {
                                if(double.TryParse(z.Text, out double test10) && Double.Parse(z.Text) >= 0)
                                {
                                    foreach (Control z1 in this.tabPage7.Controls.OfType<TextBox>())
                                    {
                                        if(double.TryParse(z1.Text, out double test11) && Double.Parse(z1.Text) >= 0)
                                        {
                                            menu_1 = 1;
                                        }
                                        else
                                        {
                                            MessageBox.Show("ERROR: There may be missing or non-valid load values inputted, or all load values are zero");
                                            menu_1 = 0;
                                            break;
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ERROR: There may be missing or non-valid load values inputted, or all load values are zero");
                                    menu_1 = 0;
                                    break;
                                }
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR: There may be missing or non-valid load values inputted, or all load values are zero");
                            menu_1 = 0;
                            break;
                        }
                        break;
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("ERROR: There may be missing or non-valid load values inputted, or all load values are zero");
                    menu_1 = 0;
                    break;
                }
            }

            foreach (Control c in this.groupBox1.Controls.OfType<TextBox>())
            {
                if (double.TryParse(c.Text, out double test) && Double.Parse(c.Text) > 0)
                {
                    menu_2 = 1;
                }
                else
                {
                    MessageBox.Show("ERROR: There may be missing or non-valid footing values inputted");
                    menu_2 = 0;
                    break;
                }
            }

            if (spiral_reinf.Checked)
            {
                Form1.instance.radioCheck[defining_id] = 1;
                menu_3 = 1;
            }
            else if (tie_reinf.Checked)
            {
                Form1.instance.radioCheck[defining_id] = 2;
                menu_3 = 1;
            }
            else
            {
                MessageBox.Show("ERROR: Reinforcement type not checked");
                menu_3 = 0;
            }

            if (menu_1 == 1 && menu_2 == 1 && menu_3 == 1)
            {
                double weight_of_footing, total_dead_load, serve_load, req_area, prov_area, ultimate_load;
                double LC1, LC2, LC3, LC4, LC5, LC6, LC7;
                double LC21, LC22, LC23, LC24, LC25, LC26, LC27;
                double UDL = 0, ULL = 0, UEL = 0, URL = 0, UWL = 0;
                double HUDL = 0, HULL = 0, HUEL = 0, HURL = 0, HUWL = 0;
                double efa, rho_act_value = 0;

                double col_dim_final = Math.Min(Double.Parse(col_dimension_1.Text), Double.Parse(col_dimension_2.Text));
                col_dimension.Text = Convert.ToString(col_dim_final);

                double col_2_L = Double.Parse(col_dimension_1_1.Text);
                double col_2_B = Double.Parse(col_dimension_1_2.Text);

                double initial_ratio = Math.Ceiling(Math.Round(Double.Parse(footing_L.Text) / Double.Parse(footing_W.Text), 2));

                weight_of_footing = Double.Parse(unit_weight_conc.Text) * Double.Parse(footing_D.Text) * Double.Parse(footing_L.Text) * Double.Parse(footing_W.Text);
                total_dead_load = Double.Parse(dead_load.Text) + weight_of_footing;
                serve_load = Double.Parse(live_load.Text) + total_dead_load;

                LC1 = 1.4 * total_dead_load;
                LC2 = 1.2 * total_dead_load + 1.6 * Double.Parse(live_load.Text) + 0.5 * Double.Parse(roof_load.Text);
                LC3 = 1.2 * total_dead_load + 1.6 * Double.Parse(roof_load.Text) + Math.Max(1.0 * Double.Parse(live_load.Text), 0.5 * Double.Parse(wind_load.Text));
                LC4 = 1.2 * total_dead_load + 1.0 * Double.Parse(wind_load.Text) + 1.0 * Double.Parse(live_load.Text) + 0.5 * Double.Parse(roof_load.Text);
                LC5 = 1.2 * total_dead_load + 1.0 * Double.Parse(eq_load.Text) + 1.0 * Double.Parse(live_load.Text);
                LC6 = 0.9 * total_dead_load + 1.0 * Double.Parse(wind_load.Text);
                LC7 = 0.9 * total_dead_load + 1.0 * Double.Parse(eq_load.Text);

                double total_DL_2 = weight_of_footing + Double.Parse(v_dead_load_2.Text);

                LC21 = 1.4 * total_DL_2;
                LC22 = 1.2 * total_DL_2 + 1.6 * Double.Parse(v_live_load_2.Text) + 0.5 * Double.Parse(v_roof_load_2.Text);
                LC23 = 1.2 * total_DL_2 + 1.6 * Double.Parse(v_roof_load_2.Text) + Math.Max(1.0 * Double.Parse(v_live_load_2.Text), 0.5 * Double.Parse(v_wind_load_2.Text));
                LC24 = 1.2 * total_DL_2 + 1.0 * Double.Parse(v_wind_load_2.Text) + 1.0 * Double.Parse(v_live_load_2.Text) + 0.5 * Double.Parse(v_roof_load_2.Text);
                LC25 = 1.2 * total_DL_2 + 1.0 * Double.Parse(v_eq_load_2.Text) + 1.0 * Double.Parse(v_live_load_2.Text);
                LC26 = 0.9 * total_DL_2 + 1.0 * Double.Parse(v_wind_load_2.Text);
                LC27 = 0.9 * total_DL_2 + 1.0 * Double.Parse(v_eq_load_2.Text);

                req_area = serve_load / Double.Parse(bearing_capacity.Text);
                prov_area = Double.Parse(footing_L.Text) * Double.Parse(footing_W.Text);

                if (prov_area < req_area)
                {
                    area_verify.Text = "Increase provided area";
                    area_verify.ForeColor = System.Drawing.Color.Red;
                    area_verify.Visible = true;
                }
                else
                {
                    area_verify.Text = "Provided area is sufficient";
                    area_verify.ForeColor = System.Drawing.Color.Green;
                    area_verify.Visible = true;
                }

                // Output
                ULC_1.Text = Convert.ToString(LC1);
                ULC_2.Text = Convert.ToString(LC2);
                ULC_3.Text = Convert.ToString(LC3);
                ULC_4.Text = Convert.ToString(LC4);
                ULC_5.Text = Convert.ToString(LC5);
                ULC_6.Text = Convert.ToString(LC6);
                ULC_7.Text = Convert.ToString(LC7);

                ULC_21.Text = Convert.ToString(LC21);
                ULC_22.Text = Convert.ToString(LC22);
                ULC_23.Text = Convert.ToString(LC23);
                ULC_24.Text = Convert.ToString(LC24);
                ULC_25.Text = Convert.ToString(LC25);
                ULC_26.Text = Convert.ToString(LC26);
                ULC_27.Text = Convert.ToString(LC27);

                weight_footing.Text = Convert.ToString(weight_of_footing);
                total_DL.Text = Convert.ToString(total_dead_load);
                service_load.Text = Convert.ToString(serve_load);
                required_area.Text = Convert.ToString(req_area);
                provided_area.Text = Convert.ToString(prov_area);

                double ultimate_load_1 = Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(LC1, LC2), LC3), LC4), LC5), LC6), LC7);
                double ultimate_load_2 = Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(LC21, LC22), LC23), LC24), LC25), LC26), LC27);
                ultimate_load = Math.Max(ultimate_load_1, ultimate_load_2);
                ultimate_str.Text = Convert.ToString(ultimate_load);

                if (ultimate_load == LC1)
                {
                    max_1.Visible = true;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.4 * total_dead_load);
                    ULL_text.Text = "0";
                    UWL_text.Text = "0";
                    UEL_text.Text = "0";
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.4 * Double.Parse(h_dead_load.Text);
                    HULL = 0;
                    HUWL = 0;
                    HUEL = 0;
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(0);
                }
                else if (ultimate_load == LC2)
                {
                    max_1.Visible = false;
                    max_2.Visible = true;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_dead_load);
                    ULL_text.Text = Convert.ToString(1.6 * Double.Parse(live_load.Text));
                    UWL_text.Text = "0";
                    UEL_text.Text = "0";
                    URL_text.Text = Convert.ToString(0.5 * Double.Parse(roof_load.Text));

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load.Text);
                    HULL = 1.6 * Double.Parse(h_live_load.Text);
                    HUWL = 0;
                    HUEL = 0;
                    HURL = 0.5 * Double.Parse(h_roof_load.Text);

                    LL_ratio.Text = Convert.ToString(1.6);
                }
                else if (ultimate_load == LC3)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = true;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_dead_load);
                    ULL_text.Text = Convert.ToString(1.0 * Double.Parse(live_load.Text));
                    UWL_text.Text = Convert.ToString(0.5 * Double.Parse(wind_load.Text));
                    UEL_text.Text = "0";
                    URL_text.Text = Convert.ToString(1.6 * Double.Parse(roof_load.Text));

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load.Text);
                    HULL = 1.0 * Double.Parse(h_live_load.Text);
                    HUWL = 0.5 * Double.Parse(h_wind_load.Text);
                    HUEL = 0;
                    HURL = 1.6 * Double.Parse(h_roof_load.Text);

                    LL_ratio.Text = Convert.ToString(1.0);
                }
                else if (ultimate_load == LC4)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = true;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_dead_load);
                    ULL_text.Text = Convert.ToString(1.0 * Double.Parse(live_load.Text));
                    UWL_text.Text = Convert.ToString(1.0 * Double.Parse(wind_load.Text));
                    UEL_text.Text = "0";
                    URL_text.Text = Convert.ToString(0.5 * Double.Parse(roof_load.Text));

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load.Text);
                    HULL = 1.0 * Double.Parse(h_live_load.Text);
                    HUWL = 1.0 * Double.Parse(h_wind_load.Text);
                    HUEL = 0;
                    HURL = 0.5 * Double.Parse(h_roof_load.Text);

                    LL_ratio.Text = Convert.ToString(1.0);
                }
                else if (ultimate_load == LC5)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = true;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_dead_load);
                    ULL_text.Text = Convert.ToString(1.0 * Double.Parse(live_load.Text));
                    UWL_text.Text = "0";
                    UEL_text.Text = Convert.ToString(1.0 * Double.Parse(eq_load.Text));
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load.Text);
                    HULL = 1.0 * Double.Parse(h_live_load.Text);
                    HUWL = 0;
                    HUEL = 1.0 * Double.Parse(h_eq_load.Text);
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(1.0);
                }
                else if (ultimate_load == LC6)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = true;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(0.9 * total_dead_load);
                    ULL_text.Text = "0";
                    UWL_text.Text = Convert.ToString(1.0 * Double.Parse(wind_load.Text));
                    UEL_text.Text = "0";
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 0.9 * Double.Parse(h_dead_load.Text);
                    HULL = 0;
                    HUWL = 1.0 * Double.Parse(h_wind_load.Text);
                    HUEL = 0;
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(1.0);
                }
                else if (ultimate_load == LC7)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = true;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(0.9 * total_dead_load);
                    ULL_text.Text = "0";
                    UWL_text.Text = "0";
                    UEL_text.Text = Convert.ToString(1.0 * Double.Parse(eq_load.Text));
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 0.9 * Double.Parse(h_dead_load.Text);
                    HULL = 0;
                    HUWL = 0;
                    HUEL = 1.0 * Double.Parse(h_eq_load.Text);
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(0.0);
                }
                else if (ultimate_load == LC21)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = true;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.4 * total_DL_2);
                    ULL_text.Text = "0";
                    UWL_text.Text = "0";
                    UEL_text.Text = "0";
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.4 * Double.Parse(h_dead_load.Text);
                    HULL = 0;
                    HUWL = 0;
                    HUEL = 0;
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(0.0);
                }
                else if (ultimate_load == LC22)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = true;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_DL_2);
                    ULL_text.Text = Convert.ToString(1.6 * Double.Parse(v_live_load_2.Text));
                    UWL_text.Text = "0";
                    UEL_text.Text = "0";
                    URL_text.Text = Convert.ToString(0.5 * Double.Parse(v_roof_load_2.Text));

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load_2.Text);
                    HULL = 1.6 * Double.Parse(h_live_load_2.Text);
                    HUWL = 0;
                    HUEL = 0;
                    HURL = 0.5 * Double.Parse(h_roof_load_2.Text);

                    LL_ratio.Text = Convert.ToString(1.6);
                }
                else if (ultimate_load == LC3)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = true;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_DL_2);
                    ULL_text.Text = Convert.ToString(1.0 * Double.Parse(v_live_load_2.Text));
                    UWL_text.Text = Convert.ToString(0.5 * Double.Parse(v_wind_load_2.Text));
                    UEL_text.Text = "0";
                    URL_text.Text = Convert.ToString(1.6 * Double.Parse(v_roof_load_2.Text));

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load_2.Text);
                    HULL = 1.0 * Double.Parse(h_live_load_2.Text);
                    HUWL = 0.5 * Double.Parse(h_wind_load_2.Text);
                    HUEL = 0;
                    HURL = 1.6 * Double.Parse(h_roof_load_2.Text);

                    LL_ratio.Text = Convert.ToString(1.0);
                }
                else if (ultimate_load == LC4)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = true;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_DL_2);
                    ULL_text.Text = Convert.ToString(1.0 * Double.Parse(v_live_load_2.Text));
                    UWL_text.Text = Convert.ToString(1.0 * Double.Parse(v_wind_load_2.Text));
                    UEL_text.Text = "0";
                    URL_text.Text = Convert.ToString(0.5 * Double.Parse(v_roof_load_2.Text));

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load_2.Text);
                    HULL = 1.0 * Double.Parse(h_live_load_2.Text);
                    HUWL = 1.0 * Double.Parse(h_wind_load_2.Text);
                    HUEL = 0;
                    HURL = 0.5 * Double.Parse(h_roof_load_2.Text);

                    LL_ratio.Text = Convert.ToString(1.0);
                }
                else if (ultimate_load == LC5)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = true;
                    max_26.Visible = false;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(1.2 * total_DL_2);
                    ULL_text.Text = Convert.ToString(1.0 * Double.Parse(v_live_load_2.Text));
                    UWL_text.Text = "0";
                    UEL_text.Text = Convert.ToString(1.0 * Double.Parse(v_eq_load_2.Text));
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 1.2 * Double.Parse(h_dead_load_2.Text);
                    HULL = 1.0 * Double.Parse(h_live_load_2.Text);
                    HUWL = 0;
                    HUEL = 1.0 * Double.Parse(h_eq_load_2.Text);
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(1.0);
                }
                else if (ultimate_load == LC6)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = true;
                    max_27.Visible = false;

                    UDL_text.Text = Convert.ToString(0.9 * total_DL_2);
                    ULL_text.Text = "0";
                    UWL_text.Text = Convert.ToString(1.0 * Double.Parse(v_wind_load_2.Text));
                    UEL_text.Text = "0";
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 0.9 * Double.Parse(h_dead_load_2.Text);
                    HULL = 0;
                    HUWL = 1.0 * Double.Parse(h_wind_load_2.Text);
                    HUEL = 0;
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(0.0);
                }
                else if (ultimate_load == LC7)
                {
                    max_1.Visible = false;
                    max_2.Visible = false;
                    max_3.Visible = false;
                    max_4.Visible = false;
                    max_5.Visible = false;
                    max_6.Visible = false;
                    max_7.Visible = false;

                    max_21.Visible = false;
                    max_22.Visible = false;
                    max_23.Visible = false;
                    max_24.Visible = false;
                    max_25.Visible = false;
                    max_26.Visible = false;
                    max_27.Visible = true;

                    UDL_text.Text = Convert.ToString(0.9 * total_DL_2);
                    ULL_text.Text = "0";
                    UWL_text.Text = "0";
                    UEL_text.Text = Convert.ToString(1.0 * Double.Parse(v_eq_load_2.Text));
                    URL_text.Text = "0";

                    UDL = Double.Parse(UDL_text.Text);
                    ULL = Double.Parse(ULL_text.Text);
                    UWL = Double.Parse(UWL_text.Text);
                    UEL = Double.Parse(UEL_text.Text);
                    URL = Double.Parse(URL_text.Text);

                    HUDL = 0.9 * Double.Parse(h_dead_load_2.Text);
                    HULL = 0;
                    HUWL = 0;
                    HUEL = 1.0 * Double.Parse(h_eq_load_2.Text);
                    HURL = 0;

                    LL_ratio.Text = Convert.ToString(0);
                }
                else
                {

                }

                double xbar = ((Double.Parse(edge_dist.Text) * ultimate_load_1) + (Double.Parse(dist_btn_cols.Text) + Double.Parse(edge_dist.Text)) * (ultimate_load_2)) / (ultimate_load_1 + ultimate_load_2);
                double hloads = HUDL + HULL + HUWL + HUEL + HURL;
                double moment_factor = 6 * (hloads) / (Double.Parse(footing_W.Text) * Math.Pow(Double.Parse(footing_L.Text), 2));

                efa = ultimate_load / prov_area + moment_factor;
                earth_pressure.Text = Convert.ToString(efa);
                double eff_depth = Double.Parse(position_multi.Text) * (Double.Parse(footing_D.Text) - Double.Parse(concrete_cover.Text) / 1000 - Double.Parse(position_multi.Text) * Double.Parse(bar_diameter.Text) / 1000);
                effective_depth.Text = Convert.ToString(eff_depth);
                double q_combine = efa * Double.Parse(footing_W.Text);

                double crit_col_dimension = Math.Min(Math.Min(Math.Min(Double.Parse(col_dimension_1.Text), Double.Parse(col_dimension_2.Text)), Double.Parse(col_dimension_1_1.Text)), Double.Parse(col_dimension_1_2.Text));

                double crit_perim = 4 * (crit_col_dimension / 1000 + eff_depth);
                critical_perimeter.Text = Convert.ToString(crit_perim);

                // Data table

                double position1 = 0, position2, position3, position4, position5, position6, position7;
                double shear1 = 0, shear2, shear3, shear4 = 0, shear5, shear6, shear7 = 0;
                double moment1 = 0, moment2, moment3, moment4, moment5, moment6, moment7;

                position2 = Double.Parse(edge_dist.Text);
                position3 = position2;
                position5 = Double.Parse(dist_btn_cols.Text) + Double.Parse(edge_dist.Text);
                position4 = Double.Parse(edge_dist.Text) + Double.Parse(dist_btn_cols.Text) - ((Double.Parse(dist_btn_cols.Text) * position5) / (Double.Parse(dist_btn_cols.Text) * q_combine));
                position6 = position5;
                position7 = Double.Parse(footing_L.Text);

                shear2 = q_combine * Double.Parse(edge_dist.Text);
                shear3 = shear2 - ultimate_load_1;
                shear5 = shear3 + (Double.Parse(dist_btn_cols.Text) * q_combine);
                shear6 = shear5 - ultimate_load_2;

                moment2 = 0.5 * shear2 * Double.Parse(edge_dist.Text);
                moment3 = moment2;
                moment4 = moment3 + 0.5 * (Double.Parse(dist_btn_cols.Text) - ((Double.Parse(dist_btn_cols.Text) * shear5) / (Double.Parse(dist_btn_cols.Text) * q_combine))) * shear3;
                moment5 = moment4 + (0.5 * (Double.Parse(dist_btn_cols.Text) - (Double.Parse(dist_btn_cols.Text) - ((Double.Parse(dist_btn_cols.Text) * shear5) / (Double.Parse(dist_btn_cols.Text) * q_combine)))));
                moment6 = moment5;
                moment7 = moment6 + (0.5 * shear6 * (Double.Parse(footing_L.Text) - Double.Parse(edge_dist.Text) - Double.Parse(dist_btn_cols.Text)));

                position_1.Text = Convert.ToString(position1);
                position_2.Text = Convert.ToString(position2);
                position_3.Text = Convert.ToString(position3);
                position_4.Text = Convert.ToString(position4);
                position_5.Text = Convert.ToString(position5);
                position_6.Text = Convert.ToString(position6);
                position_7.Text = Convert.ToString(position7);

                shear_1.Text = Convert.ToString(shear1);
                shear_2.Text = Convert.ToString(shear2);
                shear_3.Text = Convert.ToString(shear3);
                shear_4.Text = Convert.ToString(shear4);
                shear_5.Text = Convert.ToString(shear5);
                shear_6.Text = Convert.ToString(shear6);
                shear_7.Text = Convert.ToString(shear7);

                moment_1.Text = Convert.ToString(moment1);
                moment_2.Text = Convert.ToString(moment2);
                moment_3.Text = Convert.ToString(moment3);
                moment_4.Text = Convert.ToString(moment4);
                moment_5.Text = Convert.ToString(moment5);
                moment_6.Text = Convert.ToString(moment6);
                moment_7.Text = Convert.ToString(moment7);

                double max_shear_value = Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(shear1), Math.Abs(shear2)), Math.Abs(shear3)), Math.Abs(shear4)), Math.Abs(shear5)), Math.Abs(shear6)), Math.Abs(shear7));
                double max_moment_value = Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(moment1), Math.Abs(moment2)), Math.Abs(moment3)), Math.Abs(moment4)), Math.Abs(moment5)), Math.Abs(moment6)), Math.Abs(moment7));
                max_shear.Text = Convert.ToString(max_shear_value);
                max_moment.Text = Convert.ToString(max_moment_value);
                uniform_DL.Text = Convert.ToString(q_combine);

                total_shear_1.Text = Convert.ToString(max_shear_value);
                double min_d_1 = (6 * max_shear_value) / (Double.Parse(ows_phi.Text) * Double.Parse(footing_L.Text) * 1000 * Math.Sqrt(Double.Parse(strength_fc.Text)));
                min_depth_1.Text = Convert.ToString(min_d_1);

                double Vu_2 = ultimate_load - (Double.Parse(bearing_capacity.Text) * Math.Pow((Double.Parse(col_dimension.Text) / 1000 + eff_depth), 2));
                total_shear_2.Text = Convert.ToString(Vu_2);
                double min_d_2_1 = (6 * Vu_2) / (Double.Parse(ows_phi.Text) * (1 + (2 / Double.Parse(beta_value.Text)) * Math.Sqrt(Double.Parse(strength_fc.Text)) * (1000 * crit_perim)));

                double moment = max_moment_value;
                bending_moment.Text = Convert.ToString(moment);
                double ku_param = (moment * Math.Pow(1000, 2)) / ((Double.Parse(footing_L.Text) * 1000) * Math.Pow(eff_depth * 1000, 2));
                ku_value.Text = Convert.ToString(ku_param);

                // root calculation (case 2)
                double a2 = Double.Parse(alpha_value.Text) / (1000 * crit_perim);
                double b2 = 2.0;
                double c2 = -(12 * Vu_2) / (Double.Parse(ows_phi.Text) * Math.Sqrt(Double.Parse(strength_fc.Text)) * crit_perim);

                double root_2_1 = (-b2 + Math.Sqrt(Math.Pow(b2, 2) - 4 * a2 * c2)) / (2 * a2) / 1000;
                double root_2_2 = (-b2 - Math.Sqrt(Math.Pow(b2, 2) - 4 * a2 * c2)) / (2 * a2);

                // root calculation (rho)
                double a3 = Double.Parse(tension_fy.Text) / (1.7 * Double.Parse(strength_fc.Text));
                double b3 = -1.0;
                double c3 = ku_param / (Double.Parse(ku_phi.Text) * Double.Parse(tension_fy.Text));

                double root_r1 = (-b3 + Math.Sqrt(Math.Pow(b3, 2) - 4 * a3 * c3)) / (2 * a3) / 1000;
                double root_r2 = (-b3 - Math.Sqrt(Math.Pow(b3, 2) - 4 * a3 * c3)) / (2 * a3);

                // min depths for two-way
                double min_d_2_2 = Math.Max(root_2_1, root_2_2);
                double min_d_2_3 = (Vu_2 * 3) / (Double.Parse(ows_phi.Text) * Math.Sqrt(Double.Parse(strength_fc.Text)) * 1000 * crit_perim);

                min_depth_2_1.Text = Convert.ToString(min_d_2_1);
                min_depth_2_2.Text = Convert.ToString(min_d_2_2);
                min_depth_2_3.Text = Convert.ToString(min_d_2_3);

                // min depth check

                if (eff_depth > min_d_1)
                {
                    check_1.Visible = true;
                    check_1.Text = "Ok!";
                    check_1.ForeColor = System.Drawing.Color.Green;
                }
                else if (eff_depth < min_d_1)
                {
                    check_1.Visible = true;
                    check_1.Text = "Not ok";
                    check_1.ForeColor = System.Drawing.Color.Red;
                }

                if (eff_depth > min_d_2_1)
                {
                    check_2_1.Visible = true;
                    check_2_1.Text = "Ok!";
                    check_2_1.ForeColor = System.Drawing.Color.Green;
                }
                else if (eff_depth > min_d_2_1)
                {
                    check_2_1.Visible = true;
                    check_2_1.Text = "Not ok";
                    check_2_1.ForeColor = System.Drawing.Color.Green;
                }

                if (eff_depth > min_d_2_2)
                {
                    check_2_2.Visible = true;
                    check_2_2.Text = "Ok!";
                    check_2_2.ForeColor = System.Drawing.Color.Green;
                }
                else if (eff_depth > min_d_2_2)
                {
                    check_2_2.Visible = true;
                    check_2_2.Text = "Not ok";
                    check_2_2.ForeColor = System.Drawing.Color.Green;
                }

                if (eff_depth > min_d_2_3)
                {
                    check_2_3.Visible = true;
                    check_2_3.Text = "Ok!";
                    check_2_3.ForeColor = System.Drawing.Color.Green;
                }
                else if (eff_depth > min_d_2_3)
                {
                    check_2_3.Visible = true;
                    check_2_3.Text = "Not ok";
                    check_2_3.ForeColor = System.Drawing.Color.Green;
                }

                // rho calculations

                if (root_r1 >= 0.008)
                {
                    if (root_r1 >= 0.001)
                    {
                        rho_actual.Text = Convert.ToString(root_r1);
                        rho_act_value = root_r1;
                    }
                    else if (root_r1 < 0.001)
                    {
                        rho_actual.Text = Convert.ToString(root_r2);
                        rho_act_value = root_r2;
                    }
                }
                else if (root_r1 < 0.008)
                {
                    if (root_r2 >= 0.001)
                    {
                        rho_actual.Text = Convert.ToString(root_r1);
                        rho_act_value = root_r1;
                    }
                    else if (root_r2 < 0.001)
                    {
                        rho_actual.Text = Convert.ToString(root_r2);
                        rho_act_value = root_r2;
                    }
                }

                double rho_min_value = 1.4 / Double.Parse(tension_fy.Text);
                rho_min.Text = Convert.ToString(rho_min_value);
                double rho_bal_value = 0.85 * Double.Parse(beta_value.Text) * (Double.Parse(strength_fc.Text) / Double.Parse(tension_fy.Text)) * (600 / (600 + Double.Parse(tension_fy.Text)));
                rho_bal.Text = Convert.ToString(rho_bal_value);
                double rho_max_value = rho_bal_value * ((0.003 + (Double.Parse(tension_fy.Text) / 200000)) / 0.008);
                rho_max.Text = Convert.ToString(rho_max_value);

                double rho_use_value = 0;

                if (rho_act_value > rho_min_value)
                {
                    rho_use_value = rho_act_value;
                    rho_use.Text = Convert.ToString(rho_use_value);
                }
                else if (rho_act_value < rho_min_value)
                {
                    rho_use_value = rho_min_value;
                    rho_use.Text = Convert.ToString(rho_use_value);
                }

                // Area calculation
                double area_steel_total = rho_use_value * Double.Parse(footing_L.Text) * 1000 * eff_depth * 1000;
                double area_p_bar = Math.PI / 4 * (Math.Pow((Double.Parse(bar_diameter.Text)), 2));
                double no_bars = Math.Round(Math.Ceiling(area_steel_total / area_p_bar), 0);

                min_steel_area.Text = Convert.ToString(area_steel_total);
                area_per_bar.Text = Convert.ToString(area_p_bar);
                no_of_bars.Text = Convert.ToString(no_bars);

                double spacing_value = (1000 * Double.Parse(footing_L.Text) - (2 * Double.Parse(concrete_cover.Text)) - (2 * Double.Parse(bar_diameter.Text))) / (no_bars - 1);
                spacing.Text = Convert.ToString(spacing_value);

                // Temperature and bandwidth
                double rho_temp_bars = 0;
                double As_min_temp;

                if (Double.Parse(tension_fy.Text) >= 350)
                {
                    rho_temp_bars = 0.0018;
                }
                else if (Double.Parse(tension_fy.Text) < 350)
                {
                    rho_temp_bars = 0.002;
                }
                else
                {

                }

                double As_min = (1.4 / Double.Parse(tension_fy.Text)) * Double.Parse(footing_W.Text) * Double.Parse(footing_L.Text) * 1000 * 1000;
                double As_temp = rho_temp_bars * Double.Parse(footing_L.Text) * Double.Parse(footing_D.Text) * 1000 * 1000;
                min_As_1.Text = Convert.ToString(As_min);
                min_As_2.Text = Convert.ToString(As_temp);
                min_As_rho.Text = Convert.ToString(rho_temp_bars);

                double min_As_use = Math.Min(As_min, As_temp);
                double no_of_bars_temp = Math.Round(Math.Ceiling(min_As_use / area_p_bar), 0);
                double spacing_temper = (1000 * Double.Parse(footing_W.Text) - (2 * Double.Parse(concrete_cover.Text)) - (2 * Double.Parse(bar_diameter.Text))) / (no_of_bars_temp - 1);
                no_bars_temp.Text = Convert.ToString(no_of_bars_temp);
                temp_spacing.Text = Convert.ToString(spacing_temper);

                if (As_min <= As_temp)
                {
                    as1_check.Visible = true;
                    as2_check.Visible = false;
                }
                else if (As_min > As_temp)
                {
                    as1_check.Visible = false;
                    as2_check.Visible = true;
                }

                double long_direction = Math.Max(Double.Parse(footing_L.Text), Double.Parse(footing_W.Text));
                double short_direction = Math.Min(Double.Parse(footing_L.Text), Double.Parse(footing_W.Text));
                double ratio = long_direction / short_direction;
                double larger_portion_p = 0;
                double smaller_portion_p = 0;

                if (ratio == 1)
                {
                    larger_portion_p = 50;
                    smaller_portion_p = 50;
                }
                else
                {
                    larger_portion_p = 2 / (ratio + 1) * 100;
                    smaller_portion_p = (100 - larger_portion_p);
                }

                double larger_portion = larger_portion_p / 100 * min_As_use;
                double smaller_portion = smaller_portion_p / 100 * min_As_use;

                ratio_LS.Text = Convert.ToString(ratio);
                distribution_L.Text = Convert.ToString(larger_portion);
                percent_L.Text = Convert.ToString(larger_portion_p);
                distribution_S.Text = Convert.ToString(smaller_portion);
                percent_S.Text = Convert.ToString(smaller_portion_p);

                // SHORT SIDE

                double moment_sh = max_moment_value;
                short_moment.Text = Convert.ToString(moment_sh);
                double ku_param_sh = (moment_sh * Math.Pow(1000, 2)) / ((Double.Parse(footing_W.Text) * 1000) * Math.Pow(eff_depth * 1000, 2));
                short_ku.Text = Convert.ToString(ku_param_sh);

                // Area calculation
                double area_steel_total_sh = rho_use_value * Double.Parse(footing_W.Text) * 1000 * eff_depth * 1000;
                double area_p_bar_sh = Math.PI / 4 * (Math.Pow((Double.Parse(bar_diameter.Text)), 2));
                double no_bars_sh = Math.Round(Math.Ceiling(area_steel_total_sh / area_p_bar_sh), 0);

                short_as.Text = Convert.ToString(area_steel_total_sh);
                short_apb.Text = Convert.ToString(area_p_bar_sh);
                short_no_bars.Text = Convert.ToString(no_bars_sh);

                double spacing_value_sh = (1000 * Double.Parse(footing_W.Text) - (2 * Double.Parse(concrete_cover.Text)) - (2 * Double.Parse(bar_diameter.Text))) / (no_bars - 1);
                short_spacing.Text = Convert.ToString(spacing_value_sh);

                // Temperature and bandwidth
                double rho_temp_bars_sh = 0;
                double As_min_temp_sh;

                if (Double.Parse(tension_fy.Text) >= 350)
                {
                    rho_temp_bars_sh = 0.0018;
                }
                else if (Double.Parse(tension_fy.Text) < 350)
                {
                    rho_temp_bars_sh = 0.002;
                }
                else
                {

                }

                double As_min_sh = (1.4 / Double.Parse(tension_fy.Text)) * Double.Parse(footing_W.Text) * Double.Parse(footing_L.Text) * 1000 * 1000;
                double As_temp_sh = rho_temp_bars * Double.Parse(footing_L.Text) * Double.Parse(footing_D.Text) * 1000 * 1000;
                short_min_as1.Text = Convert.ToString(As_min_sh);
                short_as_2.Text = Convert.ToString(As_temp_sh);
                short_rho_use.Text = Convert.ToString(rho_temp_bars_sh);

                double min_As_use_sh = Math.Min(As_min_sh, As_temp_sh);
                double no_of_bars_temp_sh = Math.Round(Math.Ceiling(min_As_use_sh / area_p_bar_sh), 0);
                double spacing_temper_sh = (1000 * Double.Parse(footing_W.Text) - (2 * Double.Parse(concrete_cover.Text)) - (2 * Double.Parse(bar_diameter.Text))) / (no_of_bars_temp_sh - 1);
                short_temp_no.Text = Convert.ToString(no_of_bars_temp_sh);
                short_temp_space.Text = Convert.ToString(spacing_temper_sh);

                if (As_min_sh <= As_temp_sh)
                {
                    short_use_1.Visible = true;
                    short_use_2.Visible = false;
                }
                else if (As_min_sh > As_temp_sh)
                {
                    short_use_1.Visible = false;
                    short_use_2.Visible = true;
                }

                double long_direction_sh = Math.Max(Double.Parse(footing_L.Text), Double.Parse(footing_W.Text));
                double short_direction_sh = Math.Min(Double.Parse(footing_L.Text), Double.Parse(footing_W.Text));
                double ratio_sh = long_direction_sh / short_direction_sh;
                double larger_portion_p_sh = 0;
                double smaller_portion_p_sh = 0;

                if (ratio == 1)
                {
                    larger_portion_p_sh = 50;
                    smaller_portion_p_sh = 50;
                }
                else
                {
                    larger_portion_p_sh = 2 / (ratio_sh + 1) * 100;
                    smaller_portion_p_sh = (100 - larger_portion_p_sh);
                }

                double larger_portion_sh = larger_portion_p_sh / 100 * min_As_use_sh;
                double smaller_portion_sh = smaller_portion_p_sh / 100 * min_As_use_sh;

                short_ratio.Text = Convert.ToString(ratio);
                short_lsarea.Text = Convert.ToString(larger_portion);
                short_lper.Text = Convert.ToString(larger_portion_p);
                short_ssarea.Text = Convert.ToString(smaller_portion);
                short_sper.Text = Convert.ToString(smaller_portion_p);

                // Column 1 calculations

                double col_Ag = Double.Parse(col_dimension_1.Text) * Double.Parse(col_dimension_2.Text);
                gross_area.Text = Convert.ToString(col_Ag);
                double calc_col_As = 0;
                double col_UDL = (UDL / total_dead_load) * Double.Parse(dead_load.Text) - (UDL / total_dead_load) * weight_of_footing;
                double col_Pu = ((Double.Parse(LL_ratio.Text)) * (Double.Parse(live_load.Text)) + col_UDL) * 1000;
                double Dch = Double.Parse(col_dimension.Text) + 2 * Double.Parse(concrete_cover.Text);
                double Ach = Math.PI / 4 * Math.Pow(Dch, 2);

                double col_Apb = Math.PI / 4 * Math.Pow(Double.Parse(diameter_col.Text), 2);
                double tie_Apb = Math.PI / 4 * Math.Pow(Double.Parse(tie_diameter.Text), 2);

                if (spiral_reinf.Checked)
                {
                    calc_col_As = ((col_Pu / (0.8 * 0.75)) - (0.85 * (Double.Parse(strength_fc.Text) * col_Ag))) / (Double.Parse(tension_fy.Text) - 0.85 * Double.Parse(strength_fc.Text));
                }
                else if (tie_reinf.Checked)
                {
                    calc_col_As = ((col_Pu / (0.8 * 0.65)) - (0.85 * (Double.Parse(strength_fc.Text) * col_Ag))) / (Double.Parse(tension_fy.Text) - 0.85 * Double.Parse(strength_fc.Text));
                }

                double col_As_min = 0.01 * col_Ag;
                double col_As_max = 0.08 * col_Ag;
                double col_As = 0;

                if (calc_col_As < col_As_max && calc_col_As > col_As_min)
                {
                    steel_area.Text = Convert.ToString(calc_col_As);
                    col_As = calc_col_As;
                }
                else if (calc_col_As <= col_As_min)
                {
                    steel_area.Text = Convert.ToString(col_As_min);
                    col_As = col_As_min;
                }
                else if (calc_col_As >= col_As_max)
                {
                    steel_area.Text = Convert.ToString(col_As_max);
                    col_As = col_As_max;
                }

                double N_bar_col = Math.Round(Math.Ceiling(Double.Parse(steel_area.Text) / col_Apb), 0);
                col_no_bars.Text = Convert.ToString(N_bar_col);
                double vert_spacing = 0;
                double tie_rho = 0.45 * ((col_Ag / Ach) - 1) * (Double.Parse(strength_fc.Text) / Double.Parse(tension_fy.Text));

                if (spiral_reinf.Checked)
                {
                    double s_min = 25 + Double.Parse(tie_diameter.Text);
                    double s_max = 10 + Double.Parse(tie_diameter.Text);
                    double s_spiral = (4 * tie_Apb) / (tie_rho * Dch);

                    if (s_spiral < s_max && s_spiral > s_min)
                    {
                        vertical_spacing.Text = Convert.ToString(s_spiral);
                        vert_spacing = s_spiral;
                    }
                    else if (s_spiral <= s_min)
                    {
                        vertical_spacing.Text = Convert.ToString(s_min);
                        vert_spacing = s_min;
                    }
                    else if (s_spiral >= s_max)
                    {
                        vertical_spacing.Text = Convert.ToString(s_max);
                        vert_spacing = s_max;
                    }
                }
                else if (tie_reinf.Checked)
                {
                    vert_spacing = Math.Min(Math.Min(16 * Double.Parse(bar_diameter.Text), 48 * Double.Parse(tie_diameter.Text)), Math.Min(Double.Parse(col_dimension_1.Text), Double.Parse(col_dimension_2.Text)));
                    vertical_spacing.Text = Convert.ToString(vert_spacing);
                }

                // column 2 calculations

                double col_Ag_2 = Double.Parse(col_dimension_1_1.Text) * Double.Parse(col_dimension_1_2.Text);
                gross_area_2.Text = Convert.ToString(col_Ag_2);
                double calc_col_As_2 = 0;
                double col_UDL_2 = (UDL / total_dead_load) * Double.Parse(v_dead_load_2.Text) - (UDL / total_dead_load) * weight_of_footing;
                double col_Pu_2 = ((Double.Parse(LL_ratio.Text)) * (Double.Parse(v_live_load_2.Text)) + col_UDL_2) * 1000;
                double Dch_2 = Double.Parse(col_dimension_2.Text) + 2 * Double.Parse(concrete_cover.Text);
                double Ach_2 = Math.PI / 4 * Math.Pow(Dch_2, 2);

                double col_Apb_2 = Math.PI / 4 * Math.Pow(Double.Parse(diameter_col.Text), 2);
                double tie_Apb_2 = Math.PI / 4 * Math.Pow(Double.Parse(tie_diameter.Text), 2);

                if (spiral_reinf.Checked)
                {
                    calc_col_As_2 = ((col_Pu_2 / (0.8 * 0.75)) - (0.85 * (Double.Parse(strength_fc.Text) * col_Ag_2))) / (Double.Parse(tension_fy.Text) - 0.85 * Double.Parse(strength_fc.Text));
                }
                else if (tie_reinf.Checked)
                {
                    calc_col_As_2 = ((col_Pu_2 / (0.8 * 0.65)) - (0.85 * (Double.Parse(strength_fc.Text) * col_Ag_2))) / (Double.Parse(tension_fy.Text) - 0.85 * Double.Parse(strength_fc.Text));
                }

                double col_As_min_2 = 0.01 * col_Ag_2;
                double col_As_max_2 = 0.08 * col_Ag_2;
                double col_As_2 = 0;

                if (calc_col_As_2 < col_As_max_2 && calc_col_As_2 > col_As_min_2)
                {
                    steel_area_2.Text = Convert.ToString(calc_col_As_2);
                    col_As_2 = calc_col_As_2;
                }
                else if (calc_col_As_2 <= col_As_min_2)
                {
                    steel_area_2.Text = Convert.ToString(col_As_min_2);
                    col_As_2 = col_As_min_2;
                }
                else if (calc_col_As_2 >= col_As_max_2)
                {
                    steel_area_2.Text = Convert.ToString(col_As_max_2);
                    col_As_2 = col_As_max_2;
                }

                double N_bar_col_2 = Math.Round(Math.Ceiling(Double.Parse(steel_area_2.Text) / col_Apb_2), 0);
                col_no_bars_2.Text = Convert.ToString(N_bar_col_2);
                double vert_spacing_2 = 0;
                double tie_rho_2 = 0.45 * ((col_Ag_2 / Ach_2) - 1) * (Double.Parse(strength_fc.Text) / Double.Parse(tension_fy.Text));

                if (spiral_reinf.Checked)
                {
                    double s_min_2 = 25 + Double.Parse(tie_diameter.Text);
                    double s_max_2 = 10 + Double.Parse(tie_diameter.Text);
                    double s_spiral_2 = (4 * tie_Apb_2) / (tie_rho_2 * Dch_2);

                    if (s_spiral_2 < s_max_2 && s_spiral_2 > s_min_2)
                    {
                        vertical_spacing_2.Text = Convert.ToString(s_spiral_2);
                        vert_spacing_2 = s_spiral_2;
                    }
                    else if (s_spiral_2 <= s_min_2)
                    {
                        vertical_spacing_2.Text = Convert.ToString(s_min_2);
                        vert_spacing_2 = s_min_2;
                    }
                    else if (s_spiral_2 >= s_max_2)
                    {
                        vertical_spacing_2.Text = Convert.ToString(s_max_2);
                        vert_spacing_2 = s_max_2;
                    }
                }
                else if (tie_reinf.Checked)
                {
                    vert_spacing_2 = Math.Min(Math.Min(16 * Double.Parse(bar_diameter.Text), 48 * Double.Parse(tie_diameter.Text)), Double.Parse(col_dimension_2.Text));
                    vertical_spacing_2.Text = Convert.ToString(vert_spacing_2);
                }
            }
            else
            {

            }
        }

        private void max_1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void save_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you want to update footing?", "Update", MessageBoxButtons.OKCancel);
            if (dialogresult == DialogResult.OK)
            {
                foreach (Control x in this.tabPage3.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(x.Text, out double test8))
                    {

                    }
                    else
                    {
                        x.Text = Convert.ToString(-1234512345);
                    }
                }

                foreach (Control x1 in this.tabPage4.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(x1.Text, out double test9))
                    {

                    }
                    else
                    {
                        x1.Text = Convert.ToString(-1234512345);
                    }
                }

                foreach (Control y in this.tabPage6.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(y.Text, out double test10))
                    {

                    }
                    else
                    {
                        y.Text = Convert.ToString(-1234512345);
                    }
                }

                foreach (Control y1 in this.tabPage7.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(y1.Text, out double test11))
                    {

                    }
                    else
                    {
                        y1.Text = Convert.ToString(-1234512345);
                    }
                }

                foreach (Control c in this.groupBox1.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(c.Text, out double test12))
                    {

                    }
                    else
                    {
                        c.Text = Convert.ToString(-1234512345);
                    }
                }

                if (spiral_reinf.Checked)
                {
                    Form1.instance.radioCheck[defining_id] = 1;
                }
                else if (tie_reinf.Checked)
                {
                    Form1.instance.radioCheck[defining_id] = 2;
                }
                else
                {
                    Form1.instance.radioCheck[defining_id] = 3;
                }

                if (Form1.instance.loaded != 1)
                {
                    String searchValue = Convert.ToString(defining_id);
                    int rowIndex = -1;
                    int check = 0;
                    foreach (DataGridViewRow row in Form1.instance.GV_public.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            check = 1;
                        }
                    }
                    if (check == 1)
                    {
                        Form1.instance.GV_public.Rows[rowIndex].SetValues(Form1.instance.px, Double.Parse(col_dimension_1.Text), Double.Parse(col_dimension_1_1.Text), Double.Parse(col_dimension_2.Text), Double.Parse(col_dimension_1_2.Text), Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), Double.Parse(footing_W.Text), Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), Double.Parse(v_dead_load_2.Text), Double.Parse(v_live_load_2.Text), Double.Parse(v_wind_load_2.Text), Double.Parse(v_eq_load_2.Text), Double.Parse(v_roof_load_2.Text), Double.Parse(h_dead_load_2.Text), Double.Parse(h_live_load_2.Text), Double.Parse(h_wind_load_2.Text), Double.Parse(h_eq_load_2.Text), Double.Parse(h_roof_load_2.Text), Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), Double.Parse(edge_dist.Text), Double.Parse(dist_btn_cols.Text), Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);
                        foreach (Control c in this.groupBox1.Controls.OfType<TextBox>())
                        {
                            if (c.Text == Convert.ToString(-1234512345))
                            {
                                c.Text = "";
                            }
                        }
                        foreach (Control x in this.tabPage3.Controls.OfType<TextBox>())
                        {
                            if (x.Text == Convert.ToString(-1234512345))
                            {
                                x.Text = "";
                            }
                        }
                        foreach (Control y in this.tabPage4.Controls.OfType<TextBox>())
                        {
                            if (y.Text == Convert.ToString(-1234512345))
                            {
                                y.Text = "";
                            }
                        }
                        foreach (Control x1 in this.tabPage6.Controls.OfType<TextBox>())
                        {
                            if (x1.Text == Convert.ToString(-1234512345))
                            {
                                x1.Text = "";
                            }
                        }
                        foreach (Control y1 in this.tabPage7.Controls.OfType<TextBox>())
                        {
                            if (y1.Text == Convert.ToString(-1234512345))
                            {
                                y1.Text = "";
                            }
                        }

                        update_text.Text = "Last updated: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been updated");
                    }
                    else
                    {
                        Form1.instance.GV_public.Rows.Add(Form1.instance.px, Double.Parse(col_dimension_1.Text), Double.Parse(col_dimension_1_1.Text), Double.Parse(col_dimension_2.Text), Double.Parse(col_dimension_1_2.Text), Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), Double.Parse(footing_W.Text), Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), Double.Parse(v_dead_load_2.Text), Double.Parse(v_live_load_2.Text), Double.Parse(v_wind_load_2.Text), Double.Parse(v_eq_load_2.Text), Double.Parse(v_roof_load_2.Text), Double.Parse(h_dead_load_2.Text), Double.Parse(h_live_load_2.Text), Double.Parse(h_wind_load_2.Text), Double.Parse(h_eq_load_2.Text), Double.Parse(h_roof_load_2.Text), Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), Double.Parse(edge_dist.Text), Double.Parse(dist_btn_cols.Text), Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);
                        foreach (Control c in this.groupBox1.Controls.OfType<TextBox>())
                        {
                            if (c.Text == Convert.ToString(-1234512345))
                            {
                                c.Text = "";
                            }
                        }
                        foreach (Control x in this.tabPage3.Controls.OfType<TextBox>())
                        {
                            if (x.Text == Convert.ToString(-1234512345))
                            {
                                x.Text = "";
                            }
                        }
                        foreach (Control y in this.tabPage4.Controls.OfType<TextBox>())
                        {
                            if (y.Text == Convert.ToString(-1234512345))
                            {
                                y.Text = "";
                            }
                        }
                        foreach (Control x1 in this.tabPage6.Controls.OfType<TextBox>())
                        {
                            if (x1.Text == Convert.ToString(-1234512345))
                            {
                                x1.Text = "";
                            }
                        }
                        foreach (Control y1 in this.tabPage7.Controls.OfType<TextBox>())
                        {
                            if (y1.Text == Convert.ToString(-1234512345))
                            {
                                y1.Text = "";
                            }
                        }

                        update_text.Text = "Last updated: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been updated");
                    }
                }
                else if(Form1.instance.loaded == 1)
                {
                    String searchValue = Convert.ToString(defining_id);
                    int rowIndex = -1;
                    int check = 0;
                    foreach (DataGridViewRow row in Form1.instance.GV_public.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            check = 1;
                        }
                    }
                    if (check == 1)
                    {
                        Form1.instance.GV_public.Rows[rowIndex].SetValues(Form1.instance.px, Double.Parse(col_dimension_1.Text), Double.Parse(col_dimension_1_1.Text), Double.Parse(col_dimension_2.Text), Double.Parse(col_dimension_1_2.Text), Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), Double.Parse(footing_W.Text), Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), Double.Parse(v_dead_load_2.Text), Double.Parse(v_live_load_2.Text), Double.Parse(v_wind_load_2.Text), Double.Parse(v_eq_load_2.Text), Double.Parse(v_roof_load_2.Text), Double.Parse(h_dead_load_2.Text), Double.Parse(h_live_load_2.Text), Double.Parse(h_wind_load_2.Text), Double.Parse(h_eq_load_2.Text), Double.Parse(h_roof_load_2.Text), Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), Double.Parse(edge_dist.Text), Double.Parse(dist_btn_cols.Text), Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);
                        foreach (Control c in this.groupBox1.Controls.OfType<TextBox>())
                        {
                            if (c.Text == Convert.ToString(-1234512345))
                            {
                                c.Text = "";
                            }
                        }
                        foreach (Control x in this.tabPage3.Controls.OfType<TextBox>())
                        {
                            if (x.Text == Convert.ToString(-1234512345))
                            {
                                x.Text = "";
                            }
                        }
                        foreach (Control y in this.tabPage4.Controls.OfType<TextBox>())
                        {
                            if (y.Text == Convert.ToString(-1234512345))
                            {
                                y.Text = "";
                            }
                        }
                        foreach (Control x1 in this.tabPage6.Controls.OfType<TextBox>())
                        {
                            if (x1.Text == Convert.ToString(-1234512345))
                            {
                                x1.Text = "";
                            }
                        }
                        foreach (Control y1 in this.tabPage7.Controls.OfType<TextBox>())
                        {
                            if (y1.Text == Convert.ToString(-1234512345))
                            {
                                y1.Text = "";
                            }
                        }

                        update_text.Text = "Last updated: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been updated");
                    }
                    else
                    {
                        DataTable dt = Form1.instance.GV_public.DataSource as DataTable;
                        dt.Rows.Add(Form1.instance.px, Double.Parse(col_dimension_1.Text), Double.Parse(col_dimension_1_1.Text), Double.Parse(col_dimension_2.Text), Double.Parse(col_dimension_1_2.Text), Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), Double.Parse(footing_W.Text), Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), Double.Parse(v_dead_load_2.Text), Double.Parse(v_live_load_2.Text), Double.Parse(v_wind_load_2.Text), Double.Parse(v_eq_load_2.Text), Double.Parse(v_roof_load_2.Text), Double.Parse(h_dead_load_2.Text), Double.Parse(h_live_load_2.Text), Double.Parse(h_wind_load_2.Text), Double.Parse(h_eq_load_2.Text), Double.Parse(h_roof_load_2.Text), Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), Double.Parse(edge_dist.Text), Double.Parse(dist_btn_cols.Text), Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);
                        Form1.instance.GV_public.DataSource = dt;
                        foreach (Control c in this.groupBox1.Controls.OfType<TextBox>())
                        {
                            if (c.Text == Convert.ToString(-1234512345))
                            {
                                c.Text = "";
                            }
                        }
                        foreach (Control x in this.tabPage3.Controls.OfType<TextBox>())
                        {
                            if (x.Text == Convert.ToString(-1234512345))
                            {
                                x.Text = "";
                            }
                        }
                        foreach (Control y in this.tabPage4.Controls.OfType<TextBox>())
                        {
                            if (y.Text == Convert.ToString(-1234512345))
                            {
                                y.Text = "";
                            }
                        }
                        foreach (Control x1 in this.tabPage6.Controls.OfType<TextBox>())
                        {
                            if (x1.Text == Convert.ToString(-1234512345))
                            {
                                x1.Text = "";
                            }
                        }
                        foreach (Control y1 in this.tabPage7.Controls.OfType<TextBox>())
                        {
                            if (y1.Text == Convert.ToString(-1234512345))
                            {
                                y1.Text = "";
                            }
                        }

                        update_text.Text = "Last updated: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been updated");
                    }
                }
            }
            else if(dialogresult == DialogResult.Cancel)
            {

            }
        }

        private void dead_load_TextChanged(object sender, EventArgs e)
        {

        }
    }           
}               
                
                
                
                
                
                
                
                
                