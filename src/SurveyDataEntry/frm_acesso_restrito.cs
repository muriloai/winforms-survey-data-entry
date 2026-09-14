using System;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class frm_acesso_restrito : Form
    {
        private frm_menu menu;

        public frm_acesso_restrito(frm_menu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string login = (this.txt_login.Text ?? "").Trim();
            string senha = (this.txt_senha.Text ?? "").Trim();

            bool ehAdmin = (login.Equals("admin", StringComparison.OrdinalIgnoreCase) && (senha == "admin" || senha == "admin123"))
                        || (login.Equals("supercentral", StringComparison.OrdinalIgnoreCase) && senha.Equals("central2014", StringComparison.OrdinalIgnoreCase));

            if (ehAdmin)
            {
                menu.liberar_areaRestrita(1);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menu.liberar_areaRestrita(0);
                this.Close();
            }
        }

        private void frm_acesso_restrito_Load(object sender, EventArgs e)
        {
        }

        private void frm_acesso_restrito_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txt_senha.Text) && !string.IsNullOrEmpty(txt_login.Text))
            {
                btn_entrar_Click(this, null);
            }
        }
    }
}
