using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Actions;
using Entities;

namespace Forms
{
    public partial class AddSketchForm : Form
    {
        private const string notSelected = "Данные не выбраны";

        private readonly List<Style> styles;
        private readonly List<Size> sizes;
        private readonly BusinessLogic bl;

        public AddSketchForm(BusinessLogic bl)
        {
            InitializeComponent();

            this.bl = bl;
            styles = bl.GetStyles();
            cbStyle.Items.AddRange(styles.Select(n => n.Name).ToArray());

            sizes = bl.GetSizes();
            cbSize.Items.AddRange(sizes.Select(n => n.Sizes).ToArray());
        }

        private void btnAddSketch_Click(object sender, EventArgs e) => AddSketch();

        private void AddSketch()
        {
            if (!IsSelected())
            {
                MessageBox.Show(notSelected);
                return;
            }

            Style style = styles[cbStyle.SelectedIndex];
            Size size = sizes[cbSize.SelectedIndex];
            bl.AddSketch(style, size);

            Close();
        }

        private bool IsSelected()
        {
            return cbStyle.SelectedIndex != -1 && cbSize.SelectedIndex != -1;
        }
    }
}
