﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicGitClient
{
    public partial class CommitCommentWindow : Form
    {
        public delegate void CommitCommentStringHandler(string comment, EventArgs e);
        public event CommitCommentStringHandler CommitCommentEvent;

        public CommitCommentWindow()
        {
            InitializeComponent();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            CommitCommentStringHandler handler = CommitCommentEvent;
            if (handler != null)
            {
                handler(tbComment.Text, new EventArgs());
            }

            this.Close();
        }
    }
}