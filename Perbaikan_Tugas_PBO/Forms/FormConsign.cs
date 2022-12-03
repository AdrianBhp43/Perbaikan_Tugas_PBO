using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perbaikan_Tugas_PBO.Forms
{
    public partial class FormConsign : Form
    {
        public FormConsign()
        {
            InitializeComponent();
            this.Size = new Size(816, 440);
            LoadTheme();
        }

        private void FormConsign_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }
    


        private void btnSelanjutnya_Click(object sender, EventArgs e)
        {
            if ((tbKodeBarang.Text).All(Char.IsNumber))
            {
                if (cbKondisiBarang.Text != "")
                {
                    if (tbNamaPengirim.Text != "")
                    {
                        if (tbAlamatPengirim.Text != "")
                        {
                            if (Regex.IsMatch(tbNomorTelepon1.Text, @"^\d{4}-\d{4}-\d{4}$"))
                            {
                                if (tbNamaPenerima.Text != "")
                                {
                                    if (tbAlamatPenerima.Text != "")
                                    {
                                        if (Regex.IsMatch(tbNomorTelepon2.Text, @"^\d{4}-\d{4}-\d{4}$"))
                                        {
                                            if (rbTransfer.Checked || rbRekber.Checked || rbKartuKredit.Checked || rbDirectDebit.Checked)
                                            {
                                                MessageBox.Show(
                                                "Sudah Berhasil Diisi !",
                                                "Informasi Data Submit",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Size = new Size(816, 717);
                                            }
                                            else
                                            {
                                                MessageBox.Show(
                                                "Metode Pembayran Belum Dipilih !",
                                                "Informasi Data Submit",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                        MessageBox.Show(
                                        "Inputan Nomor Telepon Hanya Boleh Angka !",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(
                                        "Alamat Penerima Belum Diisi!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(
                                    "Nama Penerima Belum Diisi!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                "Inputan Nomor Telepon Hanya Boleh Angka !",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Alamat Pengirim Belum Diisi!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Nama Pengirim Belum Diisi!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Kondisi Barang Belum Diisi!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                "Inputan Kode Barang Hanya Boleh Angka !",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbNomorTelepon1_TextChanged(object sender, EventArgs e)
        {
            if (tbNomorTelepon1.Text == "")
            {
                epWrong.SetError(tbNomorTelepon1, "");
            }
            else
            {
                if (Regex.IsMatch(tbNomorTelepon1.Text, @"^\d{4}-\d{4}-\d{4}$"))
                {
                    epWrong.SetError(tbNomorTelepon1, "");

                }
                else
                {
                    epWrong.SetError(tbNomorTelepon1, "Format Nomor Telepon salah!\nContoh: 0899-8777-8999 ");

                }
            }
        }

        private void tbNomorTelepon2_TextChanged(object sender, EventArgs e)
        {
            if (tbNomorTelepon2.Text == "")
            {
                epWrong.SetError(tbNomorTelepon2, "");
            }
            else
            {
                if (Regex.IsMatch(tbNomorTelepon2.Text, @"^\d{4}-\d{4}-\d{4}$"))
                {
                    epWrong.SetError(tbNomorTelepon2, "");

                }
                else
                {
                    epWrong.SetError(tbNomorTelepon2, "Format Nomor Telepon salah!\nContoh: 0899-8777-8999 ");

                }
            }
        }

        private void tbKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text == "")
            {
                epWrong.SetError(tbKodeBarang, "");
            }
            else
            {
                if ((tbKodeBarang.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(tbKodeBarang, "");

                }
                else
                {
                    epWrong.SetError(tbKodeBarang, "Inputan Kode Barang Hanya Boleh Angka !");

                }
            }
        }

        private void rbB1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbB1.Checked)
            {
                cb1.Enabled = true; cb1.Checked = false;
                cb2.Enabled = true; cb2.Checked = false;
                cb3.Enabled = false; cb3.Checked = false;
                cb4.Enabled = false; cb4.Checked = false;
                cb5.Enabled = false; cb5.Checked = false;
                cb6.Enabled = false; cb6.Checked = false;
                cb7.Enabled = false; cb7.Checked = false;
                cb8.Enabled = false; cb8.Checked = false;
            }
        }

        private void rbB2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbB2.Checked)
            {
                cb1.Enabled = false; cb1.Checked = false;
                cb2.Enabled = false; cb2.Checked = false;
                cb3.Enabled = true; cb3.Checked = false;
                cb4.Enabled = true; cb4.Checked = false;
                cb5.Enabled = false; cb5.Checked = false;
                cb6.Enabled = false; cb6.Checked = false;
                cb7.Enabled = false; cb7.Checked = false;
                cb8.Enabled = false; cb8.Checked = false;
            }
        }

        private void rbB3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbB3.Checked)
            {
                cb1.Enabled = false; cb1.Checked = false;
                cb2.Enabled = false; cb2.Checked = false;
                cb3.Enabled = false; cb3.Checked = false;
                cb4.Enabled = false; cb4.Checked = false;
                cb5.Enabled = true; cb5.Checked = false;
                cb6.Enabled = true; cb6.Checked = false;
                cb7.Enabled = false; cb7.Checked = false;
                cb8.Enabled = false; cb8.Checked = false;
            }
        }

        private void rbB4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbB4.Checked)
            {
                cb1.Enabled = false; cb1.Checked = false;
                cb2.Enabled = false; cb2.Checked = false;
                cb3.Enabled = false; cb3.Checked = false;
                cb4.Enabled = false; cb4.Checked = false;
                cb5.Enabled = false; cb5.Checked = false;
                cb6.Enabled = false; cb6.Checked = false;
                cb7.Enabled = true; cb7.Checked = false;
                cb8.Enabled = true; cb8.Checked = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string MetodePembayaran = null;
            if (rbTransfer.Checked)
            {
                MetodePembayaran = rbTransfer.Text;
            }
            else if (rbRekber.Checked)
            {
                MetodePembayaran = rbRekber.Text;
            }
            else if (rbKartuKredit.Checked)
            {
                MetodePembayaran = rbKartuKredit.Text;
            }
            else
            {
                MetodePembayaran = rbDirectDebit.Text;
            }

            string BeratBarang = null;

            if (rbB1.Checked)
            {
                BeratBarang = rbB1.Text;
            }
            else if (rbB1.Checked)
            {
                BeratBarang = rbB2.Text;
            }
            else if (rbB3.Checked)
            {
                BeratBarang = rbB3.Text;
            }
            else
            {
                BeratBarang = rbB4.Text;
            }

            string PaketPengiriman = null;

            if (cb1.Checked)
            {
                PaketPengiriman += cb1.Text + ", ";
            }
            if (cb2.Checked)
            {
                PaketPengiriman += cb2.Text + ", ";
            }
            if (cb3.Checked)
            {
                PaketPengiriman += cb3.Text + ", ";
            }
            if (cb4.Checked)
            {
                PaketPengiriman += cb4.Text + ", ";
            }
            if (cb5.Checked)
            {
                PaketPengiriman += cb5.Text + ", ";
            }
            if (cb6.Checked)
            {
                PaketPengiriman += cb6.Text + ", ";
            }
            if (cb7.Checked)
            {
                PaketPengiriman += cb7.Text + ", ";
            }
            if (cb8.Checked)
            {
                PaketPengiriman += cb8.Text + ", ";
            }
            else
            {
                MessageBox.Show
                ("Kode Barang : " + tbKodeBarang.Text +
                "\nKondisi Barang : " + cbKondisiBarang.Text +
                "\nNama Pengirim : " + tbNamaPengirim +
                "\nAlamat Pengirim: " + tbAlamatPengirim +
                "\nNomor Telepon Pengirim : " + tbNomorTelepon1 +
                "\nNama Penerima : " + tbNamaPenerima +
                "\nAlamat Penerima: " + tbAlamatPenerima +
                "\nNomor Telepon Penerima : " + tbNomorTelepon2 +
                "\nMetode Pembayaran : " + MetodePembayaran +
                "\nBerat Barang : " + BeratBarang +
                "\nPaket Pengriman : " + PaketPengiriman ,
                "Data Telah Di Input",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}

