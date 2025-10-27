namespace Software_Lab5_Task3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            неизвестныеToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            константыToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripComboBox2 = new ToolStripComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            неизвестныеToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox4 = new ToolStripTextBox();
            toolStripTextBox5 = new ToolStripTextBox();
            toolStripTextBox6 = new ToolStripTextBox();
            константыToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripComboBox3 = new ToolStripComboBox();
            toolStripComboBox4 = new ToolStripComboBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { неизвестныеToolStripMenuItem, константыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // неизвестныеToolStripMenuItem
            // 
            неизвестныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2, toolStripTextBox3 });
            неизвестныеToolStripMenuItem.Name = "неизвестныеToolStripMenuItem";
            неизвестныеToolStripMenuItem.Size = new Size(115, 24);
            неизвестныеToolStripMenuItem.Text = "&Неизвестные";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Text = "0";
            toolStripTextBox1.ToolTipText = "x";
            toolStripTextBox1.TextChanged += ChangeForMenu;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            toolStripTextBox2.Text = "0";
            toolStripTextBox2.ToolTipText = "y";
            toolStripTextBox2.TextChanged += ChangeForMenu;
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 27);
            toolStripTextBox3.Text = "0";
            toolStripTextBox3.ToolTipText = "z";
            toolStripTextBox3.TextChanged += ChangeForMenu;
            // 
            // константыToolStripMenuItem
            // 
            константыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripComboBox2 });
            константыToolStripMenuItem.Name = "константыToolStripMenuItem";
            константыToolStripMenuItem.Size = new Size(97, 24);
            константыToolStripMenuItem.Text = "&Константы";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "-2", "-1", "0", "1", "2" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.ToolTipText = "a";
            toolStripComboBox1.SelectedIndexChanged += ChangeForMenu;
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox2.Items.AddRange(new object[] { "-2", "-1", "0", "1", "2" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            toolStripComboBox2.ToolTipText = "b";
            toolStripComboBox2.SelectedIndexChanged += ChangeForMenu;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { неизвестныеToolStripMenuItem1, константыToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(171, 52);
            // 
            // неизвестныеToolStripMenuItem1
            // 
            неизвестныеToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox4, toolStripTextBox5, toolStripTextBox6 });
            неизвестныеToolStripMenuItem1.Name = "неизвестныеToolStripMenuItem1";
            неизвестныеToolStripMenuItem1.Size = new Size(170, 24);
            неизвестныеToolStripMenuItem1.Text = "&Неизвестные";
            // 
            // toolStripTextBox4
            // 
            toolStripTextBox4.Name = "toolStripTextBox4";
            toolStripTextBox4.Size = new Size(100, 27);
            toolStripTextBox4.Text = "0";
            toolStripTextBox4.ToolTipText = "x";
            toolStripTextBox4.TextChanged += ChangeForContextMenu;
            // 
            // toolStripTextBox5
            // 
            toolStripTextBox5.Name = "toolStripTextBox5";
            toolStripTextBox5.Size = new Size(100, 27);
            toolStripTextBox5.Text = "0";
            toolStripTextBox5.ToolTipText = "y";
            toolStripTextBox5.TextChanged += ChangeForContextMenu;
            // 
            // toolStripTextBox6
            // 
            toolStripTextBox6.Name = "toolStripTextBox6";
            toolStripTextBox6.Size = new Size(100, 27);
            toolStripTextBox6.Text = "0";
            toolStripTextBox6.ToolTipText = "z";
            toolStripTextBox6.TextChanged += ChangeForContextMenu;
            // 
            // константыToolStripMenuItem1
            // 
            константыToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox3, toolStripComboBox4 });
            константыToolStripMenuItem1.Name = "константыToolStripMenuItem1";
            константыToolStripMenuItem1.Size = new Size(170, 24);
            константыToolStripMenuItem1.Text = "&Константы";
            // 
            // toolStripComboBox3
            // 
            toolStripComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox3.Items.AddRange(new object[] { "-2", "-1", "0", "1", "2" });
            toolStripComboBox3.Name = "toolStripComboBox3";
            toolStripComboBox3.Size = new Size(121, 28);
            toolStripComboBox3.ToolTipText = "a";
            toolStripComboBox3.SelectedIndexChanged += ChangeForContextMenu;
            // 
            // toolStripComboBox4
            // 
            toolStripComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox4.Items.AddRange(new object[] { "-2", "-1", "0", "1", "2" });
            toolStripComboBox4.Name = "toolStripComboBox4";
            toolStripComboBox4.Size = new Size(121, 28);
            toolStripComboBox4.ToolTipText = "b";
            toolStripComboBox4.SelectedIndexChanged += ChangeForContextMenu;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Формула;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(169, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 196);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem неизвестныеToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripMenuItem константыToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripComboBox toolStripComboBox2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem неизвестныеToolStripMenuItem1;
        private ToolStripMenuItem константыToolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox4;
        private ToolStripTextBox toolStripTextBox5;
        private ToolStripTextBox toolStripTextBox6;
        private ToolStripComboBox toolStripComboBox3;
        private ToolStripComboBox toolStripComboBox4;
    }
}
