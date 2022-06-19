
namespace forecast
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label temp_in_kelvinLabel;
            System.Windows.Forms.Label humidityLabel;
            System.Windows.Forms.Label speed_of_windLabel;
            System.Windows.Forms.Label weatherLabel;
            System.Windows.Forms.Label time_of_dayLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label area_codeLabel;
            this.forecastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.forecastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.temp_in_kelvinTextBox = new System.Windows.Forms.TextBox();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.speed_of_windTextBox = new System.Windows.Forms.TextBox();
            this.weatherTextBox = new System.Windows.Forms.TextBox();
            this.time_of_dayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.area_codeTextBox = new System.Windows.Forms.TextBox();
            this.forecastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forecastdata = new forecast.forecastdata();
            this.forecastTableAdapter = new forecast.forecastdataTableAdapters.forecastTableAdapter();
            this.tableAdapterManager = new forecast.forecastdataTableAdapters.TableAdapterManager();
            this.forecastDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savaData = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            temp_in_kelvinLabel = new System.Windows.Forms.Label();
            humidityLabel = new System.Windows.Forms.Label();
            speed_of_windLabel = new System.Windows.Forms.Label();
            weatherLabel = new System.Windows.Forms.Label();
            time_of_dayLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            area_codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingNavigator)).BeginInit();
            this.forecastBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastBindingNavigator
            // 
            this.forecastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.forecastBindingNavigator.BindingSource = this.forecastBindingSource;
            this.forecastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.forecastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.forecastBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.forecastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.forecastBindingNavigatorSaveItem});
            this.forecastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.forecastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.forecastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.forecastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.forecastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.forecastBindingNavigator.Name = "forecastBindingNavigator";
            this.forecastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.forecastBindingNavigator.Size = new System.Drawing.Size(901, 38);
            this.forecastBindingNavigator.TabIndex = 0;
            this.forecastBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // forecastBindingNavigatorSaveItem
            // 
            this.forecastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forecastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("forecastBindingNavigatorSaveItem.Image")));
            this.forecastBindingNavigatorSaveItem.Name = "forecastBindingNavigatorSaveItem";
            this.forecastBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.forecastBindingNavigatorSaveItem.Text = "Save Data";
            this.forecastBindingNavigatorSaveItem.Click += new System.EventHandler(this.forecastBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 38);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(140, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // temp_in_kelvinLabel
            // 
            temp_in_kelvinLabel.AutoSize = true;
            temp_in_kelvinLabel.Location = new System.Drawing.Point(23, 70);
            temp_in_kelvinLabel.Name = "temp_in_kelvinLabel";
            temp_in_kelvinLabel.Size = new System.Drawing.Size(108, 20);
            temp_in_kelvinLabel.TabIndex = 3;
            temp_in_kelvinLabel.Text = "temp in kelvin:";
            // 
            // temp_in_kelvinTextBox
            // 
            this.temp_in_kelvinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "temp in kelvin", true));
            this.temp_in_kelvinTextBox.Location = new System.Drawing.Point(140, 67);
            this.temp_in_kelvinTextBox.Name = "temp_in_kelvinTextBox";
            this.temp_in_kelvinTextBox.Size = new System.Drawing.Size(200, 26);
            this.temp_in_kelvinTextBox.TabIndex = 4;
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Location = new System.Drawing.Point(23, 102);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new System.Drawing.Size(71, 20);
            humidityLabel.TabIndex = 5;
            humidityLabel.Text = "humidity:";
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "humidity", true));
            this.humidityTextBox.Location = new System.Drawing.Point(140, 99);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(200, 26);
            this.humidityTextBox.TabIndex = 6;
            // 
            // speed_of_windLabel
            // 
            speed_of_windLabel.AutoSize = true;
            speed_of_windLabel.Location = new System.Drawing.Point(23, 134);
            speed_of_windLabel.Name = "speed_of_windLabel";
            speed_of_windLabel.Size = new System.Drawing.Size(111, 20);
            speed_of_windLabel.TabIndex = 7;
            speed_of_windLabel.Text = "speed of wind:";
            // 
            // speed_of_windTextBox
            // 
            this.speed_of_windTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "speed of wind", true));
            this.speed_of_windTextBox.Location = new System.Drawing.Point(140, 131);
            this.speed_of_windTextBox.Name = "speed_of_windTextBox";
            this.speed_of_windTextBox.Size = new System.Drawing.Size(200, 26);
            this.speed_of_windTextBox.TabIndex = 8;
            // 
            // weatherLabel
            // 
            weatherLabel.AutoSize = true;
            weatherLabel.Location = new System.Drawing.Point(23, 166);
            weatherLabel.Name = "weatherLabel";
            weatherLabel.Size = new System.Drawing.Size(70, 20);
            weatherLabel.TabIndex = 9;
            weatherLabel.Text = "weather:";
            // 
            // weatherTextBox
            // 
            this.weatherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "weather", true));
            this.weatherTextBox.Location = new System.Drawing.Point(140, 163);
            this.weatherTextBox.Name = "weatherTextBox";
            this.weatherTextBox.Size = new System.Drawing.Size(200, 26);
            this.weatherTextBox.TabIndex = 10;
            // 
            // time_of_dayLabel
            // 
            time_of_dayLabel.AutoSize = true;
            time_of_dayLabel.Location = new System.Drawing.Point(23, 199);
            time_of_dayLabel.Name = "time_of_dayLabel";
            time_of_dayLabel.Size = new System.Drawing.Size(41, 20);
            time_of_dayLabel.TabIndex = 11;
            time_of_dayLabel.Text = "date";
            // 
            // time_of_dayDateTimePicker
            // 
            this.time_of_dayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastBindingSource, "time of day", true));
            this.time_of_dayDateTimePicker.Location = new System.Drawing.Point(140, 195);
            this.time_of_dayDateTimePicker.Name = "time_of_dayDateTimePicker";
            this.time_of_dayDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.time_of_dayDateTimePicker.TabIndex = 12;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(23, 230);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(36, 20);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "city:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(140, 227);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 26);
            this.cityTextBox.TabIndex = 14;
            // 
            // area_codeLabel
            // 
            area_codeLabel.AutoSize = true;
            area_codeLabel.Location = new System.Drawing.Point(23, 262);
            area_codeLabel.Name = "area_codeLabel";
            area_codeLabel.Size = new System.Drawing.Size(84, 20);
            area_codeLabel.TabIndex = 15;
            area_codeLabel.Text = "area code:";
            // 
            // area_codeTextBox
            // 
            this.area_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "area code", true));
            this.area_codeTextBox.Location = new System.Drawing.Point(140, 259);
            this.area_codeTextBox.Name = "area_codeTextBox";
            this.area_codeTextBox.Size = new System.Drawing.Size(200, 26);
            this.area_codeTextBox.TabIndex = 16;
            // 
            // forecastBindingSource
            // 
            this.forecastBindingSource.DataMember = "forecast";
            this.forecastBindingSource.DataSource = this.forecastdata;
            // 
            // forecastdata
            // 
            this.forecastdata.DataSetName = "forecastdata";
            this.forecastdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // forecastTableAdapter
            // 
            this.forecastTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.forecastTableAdapter = this.forecastTableAdapter;
            this.tableAdapterManager.UpdateOrder = forecast.forecastdataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // forecastDataGridView
            // 
            this.forecastDataGridView.AutoGenerateColumns = false;
            this.forecastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forecastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.forecastDataGridView.DataSource = this.forecastBindingSource;
            this.forecastDataGridView.Location = new System.Drawing.Point(0, 291);
            this.forecastDataGridView.Name = "forecastDataGridView";
            this.forecastDataGridView.RowHeadersWidth = 62;
            this.forecastDataGridView.RowTemplate.Height = 28;
            this.forecastDataGridView.Size = new System.Drawing.Size(901, 132);
            this.forecastDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "temp in kelvin";
            this.dataGridViewTextBoxColumn2.HeaderText = "temp in kelvin";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "humidity";
            this.dataGridViewTextBoxColumn3.HeaderText = "humidity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "speed of wind";
            this.dataGridViewTextBoxColumn4.HeaderText = "speed of wind";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "weather";
            this.dataGridViewTextBoxColumn5.HeaderText = "weather";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "time of day";
            this.dataGridViewTextBoxColumn6.HeaderText = "time of day";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn7.HeaderText = "city";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "area code";
            this.dataGridViewTextBoxColumn8.HeaderText = "area code";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // savaData
            // 
            this.savaData.Location = new System.Drawing.Point(557, 246);
            this.savaData.Name = "savaData";
            this.savaData.Size = new System.Drawing.Size(94, 35);
            this.savaData.TabIndex = 18;
            this.savaData.Text = "save data";
            this.savaData.UseVisualStyleBackColor = true;
            this.savaData.Click += new System.EventHandler(this.savaData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.savaData);
            this.Controls.Add(this.forecastDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(temp_in_kelvinLabel);
            this.Controls.Add(this.temp_in_kelvinTextBox);
            this.Controls.Add(humidityLabel);
            this.Controls.Add(this.humidityTextBox);
            this.Controls.Add(speed_of_windLabel);
            this.Controls.Add(this.speed_of_windTextBox);
            this.Controls.Add(weatherLabel);
            this.Controls.Add(this.weatherTextBox);
            this.Controls.Add(time_of_dayLabel);
            this.Controls.Add(this.time_of_dayDateTimePicker);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(area_codeLabel);
            this.Controls.Add(this.area_codeTextBox);
            this.Controls.Add(this.forecastBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingNavigator)).EndInit();
            this.forecastBindingNavigator.ResumeLayout(false);
            this.forecastBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private forecastdata forecastdata;
        private System.Windows.Forms.BindingSource forecastBindingSource;
        private forecastdataTableAdapters.forecastTableAdapter forecastTableAdapter;
        private forecastdataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator forecastBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton forecastBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox temp_in_kelvinTextBox;
        private System.Windows.Forms.TextBox humidityTextBox;
        private System.Windows.Forms.TextBox speed_of_windTextBox;
        private System.Windows.Forms.TextBox weatherTextBox;
        private System.Windows.Forms.DateTimePicker time_of_dayDateTimePicker;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox area_codeTextBox;
        private System.Windows.Forms.DataGridView forecastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button savaData;
    }
}

