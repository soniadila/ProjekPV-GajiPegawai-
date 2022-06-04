/*
 * Created by SharpDevelop.
 * User: User
 * Date: 11/05/2022
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = gaji_pegawai; Uid= root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		double[,] Arraygaji_pokok =
		{
		{ 10000000, 12500000, 15000000, 17500000},
		{ 20000000, 22500000, 25000000, 27500000},
		{ 30000000, 32500000, 35000000, 37500000}
	    };
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from pegawai";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void InsertData(){
            try{
                mycommand.Connection=co;
                mycommand.CommandText="insert into pegawai values('"+id_pegawai.Text+"','"+nama.Text+"','"+departemen.SelectedItem+"','"+golongan.SelectedItem+"','"+gaji_pokoktxt.Text+"','"+tunjangan_istritxt.Text+"','"+tunjangan_anaktxt.Text+"','"+total_gajitxt.Text+"')";
                myadapter.SelectCommand= mycommand;
                if (mycommand.ExecuteNonQuery()==1){
                    MessageBox.Show("Data berhasil disimpan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ReadData();
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

		
		public void UpdateData(){
			   try{
                mycommand.Connection=co;
                mycommand.CommandText = "update pegawai set id_pegawai='"+id_pegawai.Text+"',nama='"+nama.Text+"',departemen='"+departemen.SelectedItem+"',golongan='"+golongan.SelectedItem+"',gaji_pokok='"+gaji_pokoktxt.Text+"',tunjangan_istri='"+tunjangan_istritxt.Text+"',tunjangan_anak='"+tunjangan_anaktxt.Text+"',total_gaji='"+total_gajitxt.Text+"' where id_pegawai ='"+id_pegawai.Text+"'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery()==1){
                    MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ReadData();
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
		
		public void DeleteData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="delete from pegawai where id_pegawai='"+id_pegawai.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void search(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from pegawai where id_pegawai like '%"+cari.Text+"%' or nama like '%"+cari.Text+"%'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
			MessageBox.Show(ex.ToString());
			}
	}
		
		public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            co.Open();
            ReadData();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id_pegawai.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			departemen.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			golongan.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			gaji_pokoktxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			tunjangan_istritxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			tunjangan_anaktxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			total_gajitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			
		}
			
		void Button1Click(object sender, EventArgs e)
		{
			InsertData();	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			UpdateData();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			DeleteData();			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			id_pegawai.Clear();
			nama.Clear();
			gaji_pokoktxt.Clear();
			tunjangan_anaktxt.Clear();
			tunjangan_istritxt.Clear();
			total_gajitxt.Clear();
			departemen.SelectedIndex = golongan.SelectedIndex = -1;
			menikah.Checked = belum_menikah.Checked = pria.Checked = wanita.Checked = false;
			jumlah_anak.Value = 0;
            

		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Application.Exit();				
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button7Click(object sender, EventArgs e)
		{	
			double gaji_pokok, tunjangan_istri = 0, tunjangan_anak, total_gaji = 0;
			gaji_pokok = Arraygaji_pokok[departemen.SelectedIndex, golongan.SelectedIndex];
			
			if (pria.Checked && menikah.Checked)
				tunjangan_istri = (gaji_pokok * 10) / 100;
			
			tunjangan_anak = (jumlah_anak.Value <= 2) ? ((double) jumlah_anak.Value * gaji_pokok * 5) / 100 : (2 * gaji_pokok * 5) / 100;
			
			total_gaji = gaji_pokok + tunjangan_istri + tunjangan_anak  ;			
			
			gaji_pokoktxt.Text = gaji_pokok.ToString();
			tunjangan_istritxt.Text = tunjangan_istri.ToString();
			tunjangan_anaktxt.Text = tunjangan_anak.ToString();
			total_gajitxt.Text = total_gaji.ToString();
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
                
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			search();
		}

		
		void WanitaCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Gaji_pokoktxtTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void StatusEnter(object sender, EventArgs e)
		{
			
		}
		
		void Id_pegawaiKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void cbdepartemen(){
			departemen.Items.Add("Sales & Marketing");
			departemen.Items.Add("Accounting");
			departemen.Items.Add("IT (Information & Technology)");
		}
		
		void cbgolongan(){
			golongan.Items.Add("I");
			golongan.Items.Add("II");
			golongan.Items.Add("III");
			golongan.Items.Add("IV");
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			cbdepartemen();
			cbgolongan();
			
		}
		
		void DepartemenSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void GolonganSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void NamaTextChanged(object sender, EventArgs e)
		{
			
		}
		}
	}




	

