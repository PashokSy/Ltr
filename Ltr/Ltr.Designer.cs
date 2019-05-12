namespace Ltr
{
    partial class Ltr
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ltr));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesReaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.returnChangesButton = new System.Windows.Forms.Button();
            this.cancelChangesButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБилиотекуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выбратьВсеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерОкнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельУправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кнопкаДобавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кнопкаУдалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кнопкаИзменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кнопкаПрочитаноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приветствиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editReadedPagesButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.errorButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКолвоПрочитанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.author,
            this.pagesReaded,
            this.pagesTotal,
            this.progression});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.GridColor = System.Drawing.Color.White;
            this.dataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGrid.Location = new System.Drawing.Point(3, 61);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.RowTemplate.DividerHeight = 1;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(848, 456);
            this.dataGrid.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.HeaderText = "Название книги";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.Width = 139;
            // 
            // author
            // 
            this.author.HeaderText = "Автор";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // pagesReaded
            // 
            this.pagesReaded.HeaderText = "Прочитано страниц";
            this.pagesReaded.Name = "pagesReaded";
            this.pagesReaded.ReadOnly = true;
            // 
            // pagesTotal
            // 
            this.pagesTotal.HeaderText = "Всего страниц";
            this.pagesTotal.Name = "pagesTotal";
            this.pagesTotal.ReadOnly = true;
            // 
            // progression
            // 
            this.progression.HeaderText = "Прогресс";
            this.progression.Name = "progression";
            this.progression.ReadOnly = true;
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablePanel.Controls.Add(this.returnChangesButton);
            this.tablePanel.Controls.Add(this.cancelChangesButton);
            this.tablePanel.Controls.Add(this.searchBox);
            this.tablePanel.Controls.Add(this.statusComboBox);
            this.tablePanel.Controls.Add(this.editReadedPagesButton);
            this.tablePanel.Controls.Add(this.editButton);
            this.tablePanel.Controls.Add(this.errorPanel);
            this.tablePanel.Controls.Add(this.deleteButton);
            this.tablePanel.Controls.Add(this.dataGrid);
            this.tablePanel.Controls.Add(this.addButton);
            this.tablePanel.Location = new System.Drawing.Point(13, 29);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(858, 524);
            this.tablePanel.TabIndex = 2;
            // 
            // returnChangesButton
            // 
            this.returnChangesButton.Location = new System.Drawing.Point(456, 33);
            this.returnChangesButton.Name = "returnChangesButton";
            this.returnChangesButton.Size = new System.Drawing.Size(45, 25);
            this.returnChangesButton.TabIndex = 6;
            this.returnChangesButton.Text = "вернуть";
            this.returnChangesButton.UseVisualStyleBackColor = true;
            // 
            // cancelChangesButton
            // 
            this.cancelChangesButton.Location = new System.Drawing.Point(406, 33);
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.Size = new System.Drawing.Size(44, 25);
            this.cancelChangesButton.TabIndex = 7;
            this.cancelChangesButton.Text = "отменить";
            this.cancelChangesButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(247, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(254, 29);
            this.searchBox.TabIndex = 10;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.Items.AddRange(new object[] {
            "Сейчас читаю",
            "Обязательно прочту",
            "Может прочту",
            "Показать все книги"});
            this.statusComboBox.Location = new System.Drawing.Point(247, 33);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(153, 25);
            this.statusComboBox.TabIndex = 9;
            this.statusComboBox.SelectedValueChanged += new System.EventHandler(this.StatusComboBox_SelectedValueChanged);
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.Color.Transparent;
            this.errorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorPanel.Controls.Add(this.errorButton);
            this.errorPanel.Controls.Add(this.errorLabel);
            this.errorPanel.Location = new System.Drawing.Point(507, 3);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(345, 55);
            this.errorPanel.TabIndex = 6;
            this.errorPanel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(54, 3);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.ReadOnly = true;
            this.errorLabel.Size = new System.Drawing.Size(285, 45);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "<error code>";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(884, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.удалитьБилиотекуToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem3.Text = "Путь к библиотеке";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem4.Text = "Файл с настройками";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem5.Text = "Сохранить библиотеку";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem6.Text = "Сохранить библиотеку как";
            // 
            // удалитьБилиотекуToolStripMenuItem
            // 
            this.удалитьБилиотекуToolStripMenuItem.Name = "удалитьБилиотекуToolStripMenuItem";
            this.удалитьБилиотекуToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.удалитьБилиотекуToolStripMenuItem.Text = "Удалить билиотеку";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeyDisplayString = "Alt+Q";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьИзмененияToolStripMenuItem,
            this.вернутьИзмененияToolStripMenuItem,
            this.toolStripSeparator1,
            this.добавитьКнигуToolStripMenuItem,
            this.удалитьКнигуToolStripMenuItem,
            this.редактироватьКнигуToolStripMenuItem,
            this.редактироватьКолвоПрочитанныхToolStripMenuItem,
            this.выбратьВсеКнигиToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьИзмененияToolStripMenuItem
            // 
            this.отменитьИзмененияToolStripMenuItem.Name = "отменитьИзмененияToolStripMenuItem";
            this.отменитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.отменитьИзмененияToolStripMenuItem.Text = "Отменить изменения";
            // 
            // вернутьИзмененияToolStripMenuItem
            // 
            this.вернутьИзмененияToolStripMenuItem.Name = "вернутьИзмененияToolStripMenuItem";
            this.вернутьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.вернутьИзмененияToolStripMenuItem.Text = "Вернуть изменения";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // выбратьВсеКнигиToolStripMenuItem
            // 
            this.выбратьВсеКнигиToolStripMenuItem.Name = "выбратьВсеКнигиToolStripMenuItem";
            this.выбратьВсеКнигиToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.выбратьВсеКнигиToolStripMenuItem.Text = "Выбрать все книги";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерОкнаToolStripMenuItem,
            this.панельУправленияToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // размерОкнаToolStripMenuItem
            // 
            this.размерОкнаToolStripMenuItem.Name = "размерОкнаToolStripMenuItem";
            this.размерОкнаToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.размерОкнаToolStripMenuItem.Text = "Размер окна";
            // 
            // панельУправленияToolStripMenuItem
            // 
            this.панельУправленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кнопкаДобавитьToolStripMenuItem,
            this.кнопкаУдалитьToolStripMenuItem,
            this.кнопкаИзменитьToolStripMenuItem,
            this.кнопкаПрочитаноToolStripMenuItem});
            this.панельУправленияToolStripMenuItem.Name = "панельУправленияToolStripMenuItem";
            this.панельУправленияToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.панельУправленияToolStripMenuItem.Text = "Панель управления";
            // 
            // кнопкаДобавитьToolStripMenuItem
            // 
            this.кнопкаДобавитьToolStripMenuItem.Name = "кнопкаДобавитьToolStripMenuItem";
            this.кнопкаДобавитьToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.кнопкаДобавитьToolStripMenuItem.Text = "Кнопка \"Добавить\"";
            // 
            // кнопкаУдалитьToolStripMenuItem
            // 
            this.кнопкаУдалитьToolStripMenuItem.Name = "кнопкаУдалитьToolStripMenuItem";
            this.кнопкаУдалитьToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.кнопкаУдалитьToolStripMenuItem.Text = "Кнопка \"Удалить\"";
            // 
            // кнопкаИзменитьToolStripMenuItem
            // 
            this.кнопкаИзменитьToolStripMenuItem.Name = "кнопкаИзменитьToolStripMenuItem";
            this.кнопкаИзменитьToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.кнопкаИзменитьToolStripMenuItem.Text = "Кнопка \"Изменить\"";
            // 
            // кнопкаПрочитаноToolStripMenuItem
            // 
            this.кнопкаПрочитаноToolStripMenuItem.Name = "кнопкаПрочитаноToolStripMenuItem";
            this.кнопкаПрочитаноToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.кнопкаПрочитаноToolStripMenuItem.Text = "Кнопка \"Прочитано\"";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem,
            this.приветствиеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.ShortcutKeyDisplayString = "F1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.СправкаToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // приветствиеToolStripMenuItem
            // 
            this.приветствиеToolStripMenuItem.Name = "приветствиеToolStripMenuItem";
            this.приветствиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.приветствиеToolStripMenuItem.Text = "Приветствие";
            this.приветствиеToolStripMenuItem.Click += new System.EventHandler(this.ПриветствиеToolStripMenuItem_Click);
            // 
            // editReadedPagesButton
            // 
            this.editReadedPagesButton.BackColor = System.Drawing.Color.Transparent;
            this.editReadedPagesButton.BackgroundImage = global::Ltr.Properties.Resources.bookmark_ico;
            this.editReadedPagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editReadedPagesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editReadedPagesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.editReadedPagesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.editReadedPagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editReadedPagesButton.Location = new System.Drawing.Point(186, 3);
            this.editReadedPagesButton.Name = "editReadedPagesButton";
            this.editReadedPagesButton.Size = new System.Drawing.Size(55, 55);
            this.editReadedPagesButton.TabIndex = 8;
            this.editReadedPagesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editReadedPagesButton.UseVisualStyleBackColor = false;
            this.editReadedPagesButton.Click += new System.EventHandler(this.EditReadedPagesButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BackgroundImage = global::Ltr.Properties.Resources.change_ico;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(125, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(55, 55);
            this.editButton.TabIndex = 7;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // errorButton
            // 
            this.errorButton.BackColor = System.Drawing.Color.Transparent;
            this.errorButton.BackgroundImage = global::Ltr.Properties.Resources.error_ico;
            this.errorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.errorButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.errorButton.FlatAppearance.BorderSize = 0;
            this.errorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.errorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.errorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorButton.Location = new System.Drawing.Point(3, 3);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(45, 45);
            this.errorButton.TabIndex = 8;
            this.errorButton.UseVisualStyleBackColor = false;
            this.errorButton.Click += new System.EventHandler(this.ErrorButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = global::Ltr.Properties.Resources.delete_ico;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(64, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(55, 55);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = global::Ltr.Properties.Resources.add_ico;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 55);
            this.addButton.TabIndex = 3;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Image = global::Ltr.Properties.Resources.add_ico;
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            this.добавитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьКнигуToolStripMenuItem_Click);
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            this.удалитьКнигуToolStripMenuItem.Image = global::Ltr.Properties.Resources.delete_ico;
            this.удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            this.удалитьКнигуToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Del";
            this.удалитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            this.удалитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.УдалитьКнигуToolStripMenuItem_Click);
            // 
            // редактироватьКнигуToolStripMenuItem
            // 
            this.редактироватьКнигуToolStripMenuItem.Image = global::Ltr.Properties.Resources.change_ico;
            this.редактироватьКнигуToolStripMenuItem.Name = "редактироватьКнигуToolStripMenuItem";
            this.редактироватьКнигуToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.редактироватьКнигуToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.редактироватьКнигуToolStripMenuItem.Text = "Редактировать книгу";
            this.редактироватьКнигуToolStripMenuItem.Click += new System.EventHandler(this.РедактироватьКнигуToolStripMenuItem_Click);
            // 
            // редактироватьКолвоПрочитанныхToolStripMenuItem
            // 
            this.редактироватьКолвоПрочитанныхToolStripMenuItem.Image = global::Ltr.Properties.Resources.bookmark_ico;
            this.редактироватьКолвоПрочитанныхToolStripMenuItem.Name = "редактироватьКолвоПрочитанныхToolStripMenuItem";
            this.редактироватьКолвоПрочитанныхToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.редактироватьКолвоПрочитанныхToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.редактироватьКолвоПрочитанныхToolStripMenuItem.Text = "Прочитано страниц";
            this.редактироватьКолвоПрочитанныхToolStripMenuItem.Click += new System.EventHandler(this.РедактироватьКолвоПрочитанныхToolStripMenuItem_Click);
            // 
            // Ltr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ltr";
            this.Text = "Литература";
            this.Load += new System.EventHandler(this.Ltr_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ltr_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.errorPanel.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Button errorButton;
        private System.Windows.Forms.RichTextBox errorLabel;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesReaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn progression;
        private System.Windows.Forms.Button editReadedPagesButton;
        public System.Windows.Forms.ComboBox statusComboBox;
        public System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button returnChangesButton;
        private System.Windows.Forms.Button cancelChangesButton;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem удалитьБилиотекуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКолвоПрочитанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьВсеКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерОкнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельУправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кнопкаДобавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кнопкаУдалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кнопкаИзменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кнопкаПрочитаноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приветствиеToolStripMenuItem;
    }
}

