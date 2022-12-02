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
                                                this.Size = new Size(816, 440);
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
    }
}

