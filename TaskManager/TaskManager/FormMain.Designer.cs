namespace TaskManager
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_TODO = new System.Windows.Forms.ListView();
            this.columnDescr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWorker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddTask = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_PR = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btRemoveTask = new System.Windows.Forms.Button();
            this.listView_DONE = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.listView_TODO);
            this.groupBox1.Controls.Add(this.btAddTask);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сделать";
            // 
            // listView_TODO
            // 
            this.listView_TODO.AllowDrop = true;
            this.listView_TODO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_TODO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDescr,
            this.columnDate,
            this.columnWorker,
            this.columnStatus});
            this.listView_TODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_TODO.FullRowSelect = true;
            this.listView_TODO.HideSelection = false;
            this.listView_TODO.Location = new System.Drawing.Point(6, 25);
            this.listView_TODO.Name = "listView_TODO";
            this.listView_TODO.Size = new System.Drawing.Size(329, 344);
            this.listView_TODO.TabIndex = 1;
            this.listView_TODO.Tag = "TODO";
            this.listView_TODO.UseCompatibleStateImageBehavior = false;
            this.listView_TODO.View = System.Windows.Forms.View.Details;
            this.listView_TODO.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_TODO_ItemDrag);
            this.listView_TODO.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_TODO_DragDrop);
            this.listView_TODO.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_TODO_DragOver);
            // 
            // columnDescr
            // 
            this.columnDescr.Text = "Описание";
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата";
            // 
            // columnWorker
            // 
            this.columnWorker.Text = "Исполнитель";
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Статус";
            // 
            // btAddTask
            // 
            this.btAddTask.Location = new System.Drawing.Point(6, 375);
            this.btAddTask.Name = "btAddTask";
            this.btAddTask.Size = new System.Drawing.Size(329, 33);
            this.btAddTask.TabIndex = 0;
            this.btAddTask.Text = "Новая задача";
            this.btAddTask.UseVisualStyleBackColor = true;
            this.btAddTask.Click += new System.EventHandler(this.btAddTask_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.listView_PR);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "В процессе";
            // 
            // listView_PR
            // 
            this.listView_PR.AllowDrop = true;
            this.listView_PR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_PR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_PR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_PR.FullRowSelect = true;
            this.listView_PR.HideSelection = false;
            this.listView_PR.Location = new System.Drawing.Point(6, 25);
            this.listView_PR.Name = "listView_PR";
            this.listView_PR.Size = new System.Drawing.Size(315, 344);
            this.listView_PR.TabIndex = 2;
            this.listView_PR.Tag = "InProgress";
            this.listView_PR.UseCompatibleStateImageBehavior = false;
            this.listView_PR.View = System.Windows.Forms.View.Details;
            this.listView_PR.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_PR_ItemDrag);
            this.listView_PR.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_PR_DragDrop);
            this.listView_PR.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_PR_DragOver);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Описание";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Исполнитель";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Статус";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox3.Controls.Add(this.btRemoveTask);
            this.groupBox3.Controls.Add(this.listView_DONE);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(711, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 414);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Готово";
            // 
            // btRemoveTask
            // 
            this.btRemoveTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRemoveTask.Location = new System.Drawing.Point(6, 375);
            this.btRemoveTask.Name = "btRemoveTask";
            this.btRemoveTask.Size = new System.Drawing.Size(340, 33);
            this.btRemoveTask.TabIndex = 2;
            this.btRemoveTask.Text = "Удалить задачу";
            this.btRemoveTask.UseVisualStyleBackColor = true;
            this.btRemoveTask.Click += new System.EventHandler(this.btRemoveTask_Click);
            // 
            // listView_DONE
            // 
            this.listView_DONE.AllowDrop = true;
            this.listView_DONE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_DONE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_DONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_DONE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listView_DONE.FullRowSelect = true;
            this.listView_DONE.HideSelection = false;
            this.listView_DONE.Location = new System.Drawing.Point(6, 25);
            this.listView_DONE.Name = "listView_DONE";
            this.listView_DONE.Size = new System.Drawing.Size(334, 344);
            this.listView_DONE.TabIndex = 2;
            this.listView_DONE.Tag = "Done";
            this.listView_DONE.UseCompatibleStateImageBehavior = false;
            this.listView_DONE.View = System.Windows.Forms.View.Details;
            this.listView_DONE.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_DONE_ItemDrag);
            this.listView_DONE.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DONE_DragDrop);
            this.listView_DONE.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_DONE_DragOver);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Описание";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Исполнитель";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Статус";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAddTask;
        private System.Windows.Forms.ListView listView_TODO;
        private System.Windows.Forms.ColumnHeader columnDescr;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnWorker;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ListView listView_PR;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView_DONE;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btRemoveTask;
    }
}

