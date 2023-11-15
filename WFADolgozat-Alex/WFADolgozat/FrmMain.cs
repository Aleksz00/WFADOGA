namespace WFADolgozat
{
    public partial class FrmMain : Form
    {
        static Button[] muveletek;
        static Button muveletkivalasztas;
        public FrmMain()
        {
            InitializeComponent();
            btnKoszon.Click += BtnKoszon_Click;
            lblRed.Click += ColorChanger;
            lblBlue.Click += ColorChanger;
            lblGreen.Click += ColorChanger;

            muveletek = new Button[] { btnlOssze, btnOszt, btnSzorz, btnKivon };
            btnlOssze.Click += BtnlOssze_Click;
            btnKivon.Click += BtnKivon_Click;
            btnSzorz.Click += BtnSzorz_Click;
            btnOszt.Click += BtnOszt_Click;

            alaphelyzet.Click += Alaphelyzet_Click; ;
            btnKilep.Click += BtnKilep_Click;
            btnSzamol.Click += BtnSzamol_Click;
        }

        private void Alaphelyzet_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnSzamol_Click(object? sender, EventArgs e)
        {
            double szamol1, szamol2;
            if (!double.TryParse(txtelsoSzam.Text, out szamol1) || !double.TryParse(txtmasodikSzam.Text, out szamol2))
            {
                MessageBox.Show("Nem számokat írtál !!");
            }
            else if (muveletkivalasztas == null)
            {
                MessageBox.Show("Nem választottál mûveletet!");
            }
            else
            {
                switch (muveletkivalasztas.Text)
                {
                    case "+":
                        lblEredmeny.Text = (szamol1 + szamol2).ToString();
                        break;
                    case "-":
                        lblEredmeny.Text = (szamol1 - szamol2).ToString();
                        break;
                    case "*":
                        lblEredmeny.Text = (szamol1 * szamol2).ToString();
                        break;
                    case "/":
                        lblEredmeny.Text = (szamol1 / szamol2).ToString();
                        break;

                    default:
                        break;
                }
            }
        }

        private void BtnKilep_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOszt_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;
            muveletkivalasztas = (sender as Button);
            ChangeOthersToDefault();
        }

        private void BtnSzorz_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;
            muveletkivalasztas = (sender as Button);
            ChangeOthersToDefault();

        }

        private void BtnKivon_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;
            muveletkivalasztas = (sender as Button);
            ChangeOthersToDefault();
        }

        private void BtnlOssze_Click(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Yellow;
            muveletkivalasztas = (sender as Button);
            ChangeOthersToDefault();
        }

        private void ChangeOthersToDefault()
        {
            for (int i = 0; i < muveletek.Length; i++) if (muveletek[i] != muveletkivalasztas) muveletek[i].BackColor = DefaultBackColor;
        }

        private void BtnKoszon_Click(object? sender, EventArgs e)
        {
            if (txtName.Text.Length != 0) lblUdvozol.Text = $"Szia {txtName.Text}!";
            else MessageBox.Show("Hiányos a név !", "Mezõ hiány!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ColorChanger(object? sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.Red)
            {
                this.BackColor = Color.Red;
            }
            else if ((sender as Label).BackColor == Color.Green)
            {
                this.BackColor = Color.Green;
            }
            else if ((sender as Label).BackColor == Color.Blue)
            {
                this.BackColor = Color.Blue;
            }
        }


    }
}