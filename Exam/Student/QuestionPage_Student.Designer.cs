﻿namespace Exam
{
	partial class QuestionPage_Student
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
			this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.NextButton = new System.Windows.Forms.Button();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TimeBar = new Exam.TimeBarUC();
			this.Question = new Exam.Student.QuestionUC();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 3;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout.Controls.Add(this.Question, 0, 1);
			this.TableLayout.Controls.Add(this.NextButton, 2, 2);
			this.TableLayout.Controls.Add(this.PreviousButton, 0, 2);
			this.TableLayout.Controls.Add(this.label1, 1, 2);
			this.TableLayout.Controls.Add(this.TimeBar, 0, 0);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 3;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.Size = new System.Drawing.Size(800, 450);
			this.TableLayout.TabIndex = 0;
			// 
			// NextButton
			// 
			this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NextButton.Location = new System.Drawing.Point(690, 392);
			this.NextButton.Margin = new System.Windows.Forms.Padding(10);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(100, 48);
			this.NextButton.TabIndex = 5;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			// 
			// PreviousButton
			// 
			this.PreviousButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviousButton.Location = new System.Drawing.Point(10, 392);
			this.PreviousButton.Margin = new System.Windows.Forms.Padding(10);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.Size = new System.Drawing.Size(100, 48);
			this.PreviousButton.TabIndex = 4;
			this.PreviousButton.Text = "Previous";
			this.PreviousButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(130, 392);
			this.label1.Margin = new System.Windows.Forms.Padding(10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(540, 48);
			this.label1.TabIndex = 6;
			this.label1.Text = "13 / 30";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TimeBar
			// 
			this.TableLayout.SetColumnSpan(this.TimeBar, 3);
			this.TimeBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TimeBar.Location = new System.Drawing.Point(3, 3);
			this.TimeBar.Name = "TimeBar";
			this.TimeBar.Size = new System.Drawing.Size(794, 39);
			this.TimeBar.TabIndex = 7;
			// 
			// Question
			// 
			this.TableLayout.SetColumnSpan(this.Question, 3);
			this.Question.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Question.Location = new System.Drawing.Point(3, 48);
			this.Question.Name = "Question";
			this.Question.Size = new System.Drawing.Size(794, 331);
			this.Question.TabIndex = 9;
			// 
			// QuestionPage_Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TableLayout);
			this.Name = "QuestionPage_Student";
			this.Text = "Exam App";
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button PreviousButton;
		private System.Windows.Forms.Label label1;
		private TimeBarUC TimeBar;
		private Student.QuestionUC Question;
	}
}