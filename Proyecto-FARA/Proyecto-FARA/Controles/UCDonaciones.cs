﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proyecto_FARA;
using System.Data.SqlClient;

namespace Proyecto_FARA
{
    public partial class UCDonaciones : UserControl,iModulo
    {
        public UCDonaciones()
        {
            InitializeComponent();
        }

        private void aDOPTANTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aDOPTANTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pROYECTO_FARADataSet);

        }

        private void dONANTEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
