﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay_Manager
{
    public partial class EditSourceWindow : Form
    {
        private Source source;

        public EditSourceWindow(Source source)
        {
            InitializeComponent();

            this.source = source;
        }

        private void EditSourceWindow_Load(object sender, EventArgs e)
        {

            
            if (source.title != null) articalTitle.setText(source.title);
            if (source.url != null) UrlField.setText(source.url);
            if (source.authorFirst != null) authorFirst.setText(source.authorFirst);
            if (source.authorMiddle != null) authorMiddle.setText(source.authorMiddle);
            if (source.authorLast != null) authorLast.setText(source.authorLast);
            if (source.day != null) datePublishedDay.setText(source.day);
            if (source.month != null) datePublishedMonth.setText(source.month);
            if (source.year != null) datePublishedYear.setText(source.year);
            if (source.publisher != null) publisher.setText(source.publisher);

        }

        private void addSourceButton_Click(object sender, EventArgs e)
        {
            source.url = UrlField.Text;
            source.title = articalTitle.Text;

            source.authorFirst = authorFirst.Text;
            source.authorLast = authorLast.Text;
            source.authorMiddle = authorMiddle.Text;

            source.day = datePublishedDay.Text;
            source.month = datePublishedMonth.Text;
            source.year = datePublishedYear.Text;

            source.publisher = publisher.Text;

            Utils.updateSources();

            this.Close();

        }
    }
}
