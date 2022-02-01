using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Actions;
using Entities;

namespace Forms
{
    public partial class EditSketchForm : Form
    {
        private const string notSelected = "Данные не выбраны";

        private readonly List<Style> styles;
        private readonly List<Size> sizes;
        private readonly BusinessLogic bl;
        private readonly int id;

        public EditSketchForm(BusinessLogic bl, int id, string style, string size)
        {
            InitializeComponent();

            this.bl = bl;
            this.id = id;
            styles = bl.GetStyles();
            cbStyle.Items.AddRange(styles.Select(n => n.Name).ToArray());
            cbStyle.SelectedItem = style;

            sizes = bl.GetSizes();
            cbSize.Items.AddRange(sizes.Select(n => n.Sizes).ToArray());
            cbSize.SelectedItem = size;
        }

        private void btnEditSketch_Click(object sender, EventArgs e) => EditSketch();

        private void EditSketch()
        {
            if (!IsSelected())
            {
                MessageBox.Show(notSelected);
                return;
            }

            Style style = styles[cbStyle.SelectedIndex];
            Size size = sizes[cbSize.SelectedIndex];
            bl.EditSketch(id, style, size);

            Close();
        }

        private bool IsSelected()
        {
            return cbStyle.SelectedIndex != -1 && cbSize.SelectedIndex != -1;
        }
    }
}
