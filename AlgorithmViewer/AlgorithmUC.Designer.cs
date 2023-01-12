namespace AlgorithmViewer
{
    partial class AlgorithmUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.figureContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddFigure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveFigure = new System.Windows.Forms.ToolStripMenuItem();
            this.figureContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureContextMenu
            // 
            this.figureContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddFigure,
            this.tsmiRemoveFigure});
            this.figureContextMenu.Name = "figureContextMenu";
            this.figureContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmiAddFigure
            // 
            this.tsmiAddFigure.Name = "tsmiAddFigure";
            this.tsmiAddFigure.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddFigure.Text = "Добавить фигуру";
            // 
            // tsmiRemoveFigure
            // 
            this.tsmiRemoveFigure.Name = "tsmiRemoveFigure";
            this.tsmiRemoveFigure.Size = new System.Drawing.Size(180, 22);
            this.tsmiRemoveFigure.Text = "Удалить фигуру";
            // 
            // AlgorithmUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "AlgorithmUC";
            this.Size = new System.Drawing.Size(329, 319);
            this.figureContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip figureContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFigure;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveFigure;
    }
}
