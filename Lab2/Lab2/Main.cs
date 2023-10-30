using System;
using System.Windows.Forms;

namespace Lab2 {
    public partial class Main : Form {
        private EditTestsForm? _editTestForm;
        private PassTestForm? _passTestForm;
        private InfoForm? _infoForm;

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            _editTestForm ??= new EditTestsForm();
            _passTestForm ??= new PassTestForm();
            _infoForm ??= new InfoForm();
        }

        private void btnEditTest_Click(object sender, EventArgs e) {
            _passTestForm?.Hide();
            _infoForm?.Hide();
            _editTestForm?.Show();
        }

        private void btnPassTest_Click(object sender, EventArgs e) {
            _editTestForm?.Hide();
            _infoForm?.Hide();
            _passTestForm?.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e) {
            _editTestForm?.Hide();
            _passTestForm?.Hide();
            _infoForm?.Show();
        }
    }
}
