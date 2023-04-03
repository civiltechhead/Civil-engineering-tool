﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civil_engineering_tool
{
    public partial class Form3 : Form
    {
        // SQUARE FOOTING

        public static Form3 instance;
        public int defining_id = Form1.instance.px, opened_alert_0 = 0;

        public void save_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you want to update footing?", "Update", MessageBoxButtons.OKCancel);
            if (dialogresult == DialogResult.OK)
            {
                foreach(Control x in this.tabPage3.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(x.Text, out double test8))
                    {

                    }
                    else
                    {
                        x.Text = Convert.ToString(-1234512345);
                    }
                }

                foreach (Control y in this.tabPage4.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(y.Text, out double test9))
                    {

                    }
                    else
                    {
                        y.Text = Convert.ToString(-1234512345);
                    }
                }

                foreach (Control z in this.groupBox1.Controls.OfType<TextBox>())
                {
                    if (double.TryParse(z.Text, out double test10))
                    {

                    }
                    else
                    {
                        z.Text = Convert.ToString(-1234512345);
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
                        Form1.instance.GV_public.Rows[rowIndex].SetValues(Form1.instance.px, Double.Parse(col_dimension_1.Text), 0, 0, 0, Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), 0, Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), 0, 0, Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);

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
                        update_text.Text = "Last saved: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been saved");
                    }
                    else
                    {
                        Form1.instance.GV_public.Rows.Add(Form1.instance.px, Double.Parse(col_dimension_1.Text), 0, 0, 0, Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), 0, Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), 0, 0, Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);
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

                        update_text.Text = "Last saved: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been saved");
                    }
                }
                else if (Form1.instance.loaded == 1)
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
                        Form1.instance.GV_public.Rows[rowIndex].SetValues(Form1.instance.px, Double.Parse(col_dimension_1.Text), 0, 0, 0, Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), 0, Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), 0, 0, Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);
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

                        update_text.Text = "Last saved: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been saved");
                    }
                    else
                    {
                        DataTable dt = Form1.instance.GV_public.DataSource as DataTable;
                        dt.Rows.Add(Form1.instance.px, Double.Parse(col_dimension_1.Text), 0, 0, 0, Double.Parse(footing_T.Text), Double.Parse(footing_L.Text), 0, Double.Parse(footing_D.Text), Double.Parse(dead_load.Text), Double.Parse(live_load.Text), Double.Parse(wind_load.Text), Double.Parse(eq_load.Text), Double.Parse(roof_load.Text), Double.Parse(h_dead_load.Text), Double.Parse(h_live_load.Text), Double.Parse(h_eq_load.Text), Double.Parse(h_wind_load.Text), Double.Parse(h_roof_load.Text), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Double.Parse(concrete_cover.Text), Double.Parse(bar_diameter.Text), Double.Parse(diameter_col.Text), Double.Parse(temp_bar_col.Text), 0, Double.Parse(tie_diameter.Text), Double.Parse(ows_phi.Text), Double.Parse(ku_phi.Text), Double.Parse(position_multi.Text), Double.Parse(alpha_value.Text), Double.Parse(beta_value.Text), Double.Parse(unit_weight_conc.Text), Double.Parse(bearing_capacity.Text), Double.Parse(strength_fc.Text), Double.Parse(tension_fy.Text), 0, 0, Form1.instance.foot_type[defining_id], Form1.instance.foot_label[defining_id], Form1.instance.radioCheck[defining_id]);
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

                        update_text.Text = "Last saved: " + DateTime.Now.ToString();
                        MessageBox.Show("Footing data has been saved");
                    }
                }
            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
        }       

        public Form3()
        {
            InitializeComponent();
            instance = this;
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
                            menu_1 = 1;
                        }
                        else
                        {
                            MessageBox.Show("ERROR: There may be missing or non-valid load values inputted, or all load values are zero");
                            menu_1 = 0;
                            break;
                        }
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
                    menu_1 = 0;
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
                double UDL = 0, ULL = 0, UEL = 0, URL = 0, UWL = 0;
                double HUDL = 0, HULL = 0, HUEL = 0, HURL = 0, HUWL = 0;
                double efa, rho_act_value = 0;

                double col_dim_final = Double.Parse(col_dimension_1.Text);
                col_dimension.Text = Convert.ToString(col_dim_final);

                weight_of_footing = Double.Parse(unit_weight_conc.Text) * Double.Parse(footing_D.Text) * Double.Parse(footing_L.Text) * Double.Parse(footing_L.Text);
                total_dead_load = Double.Parse(dead_load.Text) + weight_of_footing;
                serve_load = Double.Parse(live_load.Text) + total_dead_load;

                LC1 = 1.4 * total_dead_load;
                LC2 = 1.2 * total_dead_load + 1.6 * Double.Parse(live_load.Text) + 0.5 * Double.Parse(roof_load.Text);
                LC3 = 1.2 * total_dead_load + 1.6 * Double.Parse(roof_load.Text) + Math.Max(1.0 * Double.Parse(live_load.Text), 0.5 * Double.Parse(wind_load.Text));
                LC4 = 1.2 * total_dead_load + 1.0 * Double.Parse(wind_load.Text) + 1.0 * Double.Parse(live_load.Text) + 0.5 * Double.Parse(roof_load.Text);
                LC5 = 1.2 * total_dead_load + 1.0 * Double.Parse(eq_load.Text) + 1.0 * Double.Parse(live_load.Text);
                LC6 = 0.9 * total_dead_load + 1.0 * Double.Parse(wind_load.Text);
                LC7 = 0.9 * total_dead_load + 1.0 * Double.Parse(eq_load.Text);

                req_area = serve_load / Double.Parse(bearing_capacity.Text);
                prov_area = Double.Parse(footing_L.Text) * Double.Parse(footing_L.Text);

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
                weight_footing.Text = Convert.ToString(weight_of_footing);
                total_DL.Text = Convert.ToString(total_dead_load);
                service_load.Text = Convert.ToString(serve_load);
                required_area.Text = Convert.ToString(req_area);
                provided_area.Text = Convert.ToString(prov_area);

                ultimate_load = Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(LC1, LC2), LC3), LC4), LC5), LC6), LC7);
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
                }
                else
                {

                }

                double hloads = HUDL + HULL + HUWL + HUEL + HURL;
                double moment_factor = 6 * (hloads) / (Double.Parse(footing_L.Text) * Math.Pow(Double.Parse(footing_L.Text), 2));

                efa = ultimate_load / prov_area + moment_factor;
                earth_pressure.Text = Convert.ToString(efa);
                double eff_depth = Double.Parse(position_multi.Text) * (Double.Parse(footing_D.Text) - Double.Parse(concrete_cover.Text) / 1000 - Double.Parse(position_multi.Text) * Double.Parse(bar_diameter.Text) / 1000);
                effective_depth.Text = Convert.ToString(eff_depth);

                double crit_perim = 4 * (Double.Parse(col_dimension.Text) / 1000 + eff_depth);
                critical_perimeter.Text = Convert.ToString(crit_perim);
                double Vu_1 = Double.Parse(footing_L.Text) * Double.Parse(bearing_capacity.Text) * ((Double.Parse(footing_L.Text) / 2) - (Double.Parse(col_dimension.Text) / 1000 / 2) - eff_depth);
                total_shear_1.Text = Convert.ToString(Vu_1);
                double min_d_1 = (6 * Vu_1) / (Double.Parse(ows_phi.Text) * Double.Parse(footing_L.Text) * 1000 * Math.Sqrt(Double.Parse(strength_fc.Text)));
                min_depth_1.Text = Convert.ToString(min_d_1);

                double Vu_2 = ultimate_load - (Double.Parse(bearing_capacity.Text) * Math.Pow((Double.Parse(col_dimension.Text) / 1000 + eff_depth), 2));
                total_shear_2.Text = Convert.ToString(Vu_2);
                double min_d_2_1 = (6 * Vu_2) / (Double.Parse(ows_phi.Text) * (1 + (2 / Double.Parse(beta_value.Text)) * Math.Sqrt(Double.Parse(strength_fc.Text)) * (1000 * crit_perim)));

                double moment = 0.5 * Double.Parse(bearing_capacity.Text) * Double.Parse(footing_L.Text) * ((Double.Parse(footing_L.Text) / 2) - Math.Pow((Double.Parse(col_dimension.Text) / 1000 / 2), 2));
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

                double As_min = (1.4 / Double.Parse(tension_fy.Text)) * Double.Parse(footing_L.Text) * Double.Parse(footing_L.Text) * 1000 * 1000;
                double As_temp = rho_temp_bars * Double.Parse(footing_L.Text) * Double.Parse(footing_D.Text) * 1000 * 1000;
                min_As_1.Text = Convert.ToString(As_min);
                min_As_2.Text = Convert.ToString(As_temp);
                min_As_rho.Text = Convert.ToString(rho_temp_bars);

                double min_As_use = Math.Min(As_min, As_temp);
                double no_of_bars_temp = Math.Round(Math.Ceiling(min_As_use / area_p_bar), 0);
                double spacing_temper = (1000 * Double.Parse(footing_L.Text) - (2 * Double.Parse(concrete_cover.Text)) - (2 * Double.Parse(bar_diameter.Text))) / (no_of_bars_temp - 1);
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

                double long_direction = Math.Max(Double.Parse(footing_L.Text), Double.Parse(footing_L.Text));
                double short_direction = Math.Min(Double.Parse(footing_L.Text), Double.Parse(footing_L.Text));
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

                // Column calculations

                double col_Ag = Double.Parse(col_dimension.Text) * Double.Parse(col_dimension.Text);
                gross_area.Text = Convert.ToString(col_Ag);
                double calc_col_As = 0;
                double col_UDL = UDL - (UDL / total_dead_load) * weight_of_footing;
                double col_Pu = (ULL + col_UDL) * Math.Pow(10, 3);
                double Dch = Double.Parse(col_dimension.Text) + 2 * Double.Parse(concrete_cover.Text);
                double Ach = Math.PI / 4 * Math.Pow(Dch, 2);

                double col_Apb = Math.PI / 4 * Math.Pow(Double.Parse(diameter_col.Text), 2);
                double tie_Apb = Math.PI / 4 * Math.Pow(Double.Parse(tie_diameter.Text), 2);

                if (spiral_reinf.Checked)
                {
                    calc_col_As = (col_Pu / (0.8 * 0.75) - (0.85 * (Double.Parse(strength_fc.Text) * col_Ag))) / (Double.Parse(tension_fy.Text) - 0.85 * Double.Parse(strength_fc.Text));
                }
                else if (tie_reinf.Checked)
                {
                    calc_col_As = (col_Pu / (0.8 * 0.65) - (0.85 * (Double.Parse(strength_fc.Text) * col_Ag))) / (Double.Parse(tension_fy.Text) - 0.85 * Double.Parse(strength_fc.Text));
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

                double N_bar_col = Math.Round(Math.Ceiling(col_As / col_Apb), 0);
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
                    vert_spacing = Math.Min(Math.Min(16 * Double.Parse(bar_diameter.Text), 48 * Double.Parse(tie_diameter.Text)), Double.Parse(col_dimension.Text));
                    vertical_spacing.Text = Convert.ToString(vert_spacing);
                }
            }
            else
            {

            }
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Square footing: " + Form1.instance.picked_button.Text;
            area_verify.Visible = false;
            this.MaximizeBox = false;
            this.ControlBox = false;

            if(Form1.instance.loaded == 1)
            {
                col_dimension_1.Text =             Convert.ToString(Form1.instance.ID_001[defining_id]);
                footing_T.Text =                   Convert.ToString(Form1.instance.ID_005[defining_id]);
                footing_L.Text =                   Convert.ToString(Form1.instance.ID_006[defining_id]);
                footing_D.Text =                   Convert.ToString(Form1.instance.ID_008[defining_id]);
                dead_load.Text =                   Convert.ToString(Form1.instance.ID_009[defining_id]);
                live_load.Text =                   Convert.ToString(Form1.instance.ID_010[defining_id]);
                wind_load.Text =                   Convert.ToString(Form1.instance.ID_011[defining_id]);
                eq_load.Text =                     Convert.ToString(Form1.instance.ID_012[defining_id]);
                roof_load.Text =                   Convert.ToString(Form1.instance.ID_013[defining_id]);
                h_dead_load.Text =                 Convert.ToString(Form1.instance.ID_014[defining_id]);
                h_live_load.Text =                 Convert.ToString(Form1.instance.ID_015[defining_id]);
                h_wind_load.Text =                 Convert.ToString(Form1.instance.ID_017[defining_id]);
                h_eq_load.Text =                   Convert.ToString(Form1.instance.ID_016[defining_id]);
                h_roof_load.Text =                 Convert.ToString(Form1.instance.ID_018[defining_id]);
                concrete_cover.Text =              Convert.ToString(Form1.instance.ID_029[defining_id]);
                bar_diameter.Text =                Convert.ToString(Form1.instance.ID_030[defining_id]);
                diameter_col.Text =                Convert.ToString(Form1.instance.ID_031[defining_id]);
                temp_bar_col.Text =                Convert.ToString(Form1.instance.ID_032[defining_id]);
                tie_diameter.Text =                Convert.ToString(Form1.instance.ID_034[defining_id]);
                ows_phi.Text =                     Convert.ToString(Form1.instance.ID_035[defining_id]);
                ku_phi.Text =                      Convert.ToString(Form1.instance.ID_036[defining_id]);
                position_multi.Text =              Convert.ToString(Form1.instance.ID_037[defining_id]);
                alpha_value.Text =                 Convert.ToString(Form1.instance.ID_038[defining_id]);
                beta_value.Text =                  Convert.ToString(Form1.instance.ID_039[defining_id]);
                unit_weight_conc.Text =            Convert.ToString(Form1.instance.ID_040[defining_id]);
                bearing_capacity.Text =            Convert.ToString(Form1.instance.ID_041[defining_id]);
                strength_fc.Text =                 Convert.ToString(Form1.instance.ID_042[defining_id]);
                tension_fy.Text =                  Convert.ToString(Form1.instance.ID_043[defining_id]);

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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
