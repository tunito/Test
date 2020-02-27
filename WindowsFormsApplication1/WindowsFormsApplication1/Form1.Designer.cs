using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Ex1_BubleSort
{
    public class Form1 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        private string s = "687 933 364 579 303 803 360 723 61 669 848 501 768 685 511 401 671 111 859 805 224 325 361 428 95 802 207 244 176 86 334 738 990 876 305 411 306 656 364 156 836 250 311 824 870 147 610 173 765 258 81 923 633 841 683 362 572 935 484 500 596 116 546 975 335 110 511 892 380 99 95 14 747 702 968 974 14 536 558 947 191 33 478 918 4 410 104 148 192 942 838 371 172 863 560 720 703 336 489 760 636 718 793 665 162 67 175 931 872 709 348 36 377 536 309 562 637 628 970 924 5 362 700 437 261 723 842 884 141 247 271 677 47 797 311 473 239 813 755 936 234 173 276 483 594 802 994 636 554 998 83 75 365 564 754 274 18 356 404 438 225 291 789 624 437 670 989 579 224 835 322 824 872 33 689 832 86 217 842 458 729 205 329 142 164 196 311 482 42 37 454 883 408 316 711 943 383 651 45 924 813 414 411 718 676 259 202 332 874 922 188 801 513 945 708 19 961 646 460 241 358 506 536 187 381 438 415 555 322 746 449 434 171 918 645 315 794 611 466 905 993 979 608 120 849 653 369 462 607 692 981 736 191 804 565 307 877 223 337 237 843 646 10 128 473 753 629 595 300 393 224 350 180 554 247 378 897 416 338 727 69 952 947 629 764 712 243 367 353 338 437 570 274 229 62 347 969 480 646 95 24 773 162 214 467 631 556 636 556 186 409 460 885 610 167 890 698 380 364 760 509 262 242 961 955 654 75 950 492 899 409 417 770 242 703 295 790 733 162 132 156 607 810 166 928 977 685 664 61 171 648 589 115 886 585 761 531 201 258 813 556 605 143 657 777 991 690 642 906 872 100 965 218 231 603 902 452 75 32 978 968 411 888 321 251 819 301 883 656 941 764 588 474 349 576 551 464 153 389 937 286 43 757 189 71 683 371 884 282 683 309 455 168 280 844 144 716 822 405 957 690 806 985 965 108 511 490 868 655 52 438 298 686 95 692 925 654 699 249 568 448 417 600 973 632 308 420 194 504 432 834 641 747 431 247 479 57 791 81 560 192 502 228 230 245 10 768 73 587 919 489 17 572 837 509 272 205 11 333 799 91 296 364 223 217 796 551 254 848 212 867 862 617 689 375 946 188 370 728 621 539 347 606 585 942 816 68 909 922 974 273 45 458 281 468 896 138 5 13 448 459 513 224 375 51 626 399 883 462 562 83 835 283 711 259 744 689 778 280 400 727 641 332 873 938 821 403 336 220 478 807 183 357 279 162 26 122 231 534 315 417 185 447 359 890 438 762 747 21 724 207 359 724 612 721 818 181 351 436 230 222 63 662 983 755 900 478 4 549 233 621 458 244 964 983 542 193 972 982 500 59 656 314 495 271 448 459 744 558 343 844 771 794 303 93 353 522 464 604 990 959 757 197 788 103 749 114 759 628 179 624 209 368 936 170 565 749 167 711 306 441 734 445 205 388 850 663 940 871 630 19 729 367 992 540 301 459 525 392 522 333 699 115 379 719 635 403 858 133 527 603 355 752 297 549 225 311 991 399 252 85 174 887 998 159 894 841 375 395 869 106 223 774 188 973 741 618 66 486 753 447 805 807 344 26 663 976 70 442 315 989 467 126 140 436 159 811 116 219 824 794 27 462 263 420 380 581 564 324 807 607 245 505 646 805 280 366 543 972 496 918 771 932 80 879 639 97 634 751 814 929 501 847 661 958 419 343 543 924 646 82 412 745 634 708 744 961 480 334 156 792 268 144 723 906 23 94 381 383 781 282 946 812 510 878 105 397 844 687 385 936 822 618 325 413 506 25 297 372 135 677 616 299 595 21 660 356 123 755 935 324 961 159 142 363 135 600 235 756 602 346 117 793 948 219 969 649 819 309 399 997 797 9 248 104 666 647 217 488 217 748 273 89 751 61 975 663 476 962 278 906 790 541 769 789 559 823 350 375 52 10 537 814 355 937 527 952 911 38 697 488 382 746 539 853 72 28 41 887 244 306 173 856 31 493 207 256 239 459 544 842 296 841 436 206 210 459 733 813 533 23 751 437 264 789 523 43 1 916 716 531 781 463 130 745 837 680 783 862 730 271 712 451 494 854 192 541 310 332 643 613 294 228 354 220 554 736 592 241 969 164 254 323 742 12 61 833 711 690 369 529 676 871 82 262 310 299 943 409 597 982 732 668 272 103 237 553 108 909 191 100 88 541 892 566 17 389 709 481 793 359 829 620 963 113 936 423 145 91 909 254 792 182 644 987 431 585 50 639 ";
        private Collection<int> scores = new Collection<int>();
        private IContainer components = (IContainer)null;
        private int kEnd;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListView listView1;
        private ColumnHeader clmNumber;
        private ColumnHeader clmCount;
        private Label label8;
        private Label label9;
        private Button btnResult;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = this.s;
        }

        public void pars()
        {
            string s = " ";
            char ch = ' ';
            char[] charArray = this.s.ToCharArray();
            int num = 1;
            for (int index = 0; index < this.s.Length; ++index)
            {
                if ((int)charArray[index] != (int)ch)
                {
                    s += (string)(object)charArray[index];
                }
                else
                {
                    this.scores.Add(int.Parse(s));
                    ++num;
                    s = "";
                }
            }
            this.kEnd = num;
            this.label7.Text = this.kEnd.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.stopwatch.Start();
            this.pars();
            for (int index = 0; index < this.kEnd - 1; ++index)
            {
                TextBox textBox2 = this.textBox2;
                textBox2.Text = textBox2.Text + (object)this.scores[index] + Environment.NewLine;
            }
            this.stopwatch.Stop();
            this.label1.Text = this.stopwatch.Elapsed.ToString();
        }

        public void bubleSort()
        {
            for (int index1 = 1; index1 < this.kEnd - 1; ++index1)
            {
                for (int index2 = 1; index2 < this.kEnd - 2; ++index2)
                {
                    if (this.scores[index2] > this.scores[index2 + 1])
                    {
                        int score = this.scores[index2];
                        this.scores[index2] = this.scores[index2 + 1];
                        this.scores[index2 + 1] = score;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.stopwatch.Start();
            this.bubleSort();
            this.stopwatch.Stop();
            this.label3.Text = this.stopwatch.Elapsed.ToString();
            for (int index = 1; index < this.kEnd - 1; ++index)
            {
                TextBox textBox1 = this.textBox1;
                textBox1.Text = textBox1.Text + (object)this.scores[index] + Environment.NewLine;
            }
        }

        public void NumCount()
        {
            int num = 1;
            int score = this.scores[1];
            for (int index = 2; index < this.kEnd - 1; ++index)
            {
                if (score == this.scores[index])
                {
                    ++num;
                }
                else
                {
                    this.listView1.Items.Add(new ListViewItem(new string[2]
          {
            score.ToString(),
            num.ToString()
          }));
                    score = this.scores[index];
                    num = 1;
                }
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.stopwatch.Start();
            this.NumCount();
            this.stopwatch.Stop();
            this.label9.Text = this.stopwatch.Elapsed.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.button1 = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBox1 = new TextBox();
            this.button2 = new Button();
            this.textBox2 = new TextBox();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.listView1 = new ListView();
            this.clmNumber = new ColumnHeader();
            this.clmCount = new ColumnHeader();
            this.label8 = new Label();
            this.label9 = new Label();
            this.btnResult = new Button();
            this.SuspendLayout();
            this.button1.Location = new Point(65, 397);
            this.button1.Name = "button1";
            this.button1.Size = new Size(119, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scanner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label1.BackColor = Color.White;
            this.label1.BorderStyle = BorderStyle.Fixed3D;
            this.label1.Location = new Point(15, 362);
            this.label1.Name = "label1";
            this.label1.Size = new Size(169, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            this.label1.TextAlign = ContentAlignment.MiddleRight;
            this.label2.BorderStyle = BorderStyle.FixedSingle;
            this.label2.Location = new Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new Size(531, 321);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.textBox1.Location = new Point(744, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = ScrollBars.Vertical;
            this.textBox1.Size = new Size(98, 442);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = HorizontalAlignment.Right;
            this.button2.Location = new Point(256, 397);
            this.button2.Name = "button2";
            this.button2.Size = new Size(119, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.textBox2.Location = new Point(601, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = ScrollBars.Vertical;
            this.textBox2.Size = new Size(98, 413);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = HorizontalAlignment.Right;
            this.label3.BackColor = Color.White;
            this.label3.BorderStyle = BorderStyle.Fixed3D;
            this.label3.Location = new Point(202, 362);
            this.label3.Name = "label3";
            this.label3.Size = new Size(173, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            this.label3.TextAlign = ContentAlignment.MiddleRight;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new Size(143, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Време за сканиране";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(244, 345);
            this.label5.Name = "label5";
            this.label5.Size = new Size(143, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Време за сортиране";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(511, 446);
            this.label6.Name = "label6";
            this.label6.Size = new Size(84, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Брой числа";
            this.label7.BackColor = Color.White;
            this.label7.BorderStyle = BorderStyle.Fixed3D;
            this.label7.Location = new Point(601, 441);
            this.label7.Name = "label7";
            this.label7.Size = new Size(82, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "0";
            this.label7.TextAlign = ContentAlignment.MiddleRight;
            this.listView1.Columns.AddRange(new ColumnHeader[2]
      {
        this.clmNumber,
        this.clmCount
      });
            this.listView1.GridLines = true;
            this.listView1.Location = new Point(860, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(190, 441);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.clmNumber.Text = "ЧИСЛА";
            this.clmNumber.Width = 41;
            this.clmCount.Text = "БРОЙ";
            this.clmCount.TextAlign = HorizontalAlignment.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(445, 345);
            this.label8.Name = "label8";
            this.label8.Size = new Size(143, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Време за сортиране";
            this.label9.BackColor = Color.White;
            this.label9.BorderStyle = BorderStyle.Fixed3D;
            this.label9.Location = new Point(403, 362);
            this.label9.Name = "label9";
            this.label9.Size = new Size(173, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "0";
            this.label9.TextAlign = ContentAlignment.MiddleRight;
            this.btnResult.Location = new Point(457, 397);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new Size(119, 38);
            this.btnResult.TabIndex = 14;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new EventHandler(this.btnResult_Click);
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1061, 480);
            this.Controls.Add((Control)this.btnResult);
            this.Controls.Add((Control)this.label8);
            this.Controls.Add((Control)this.label9);
            this.Controls.Add((Control)this.listView1);
            this.Controls.Add((Control)this.label7);
            this.Controls.Add((Control)this.label6);
            this.Controls.Add((Control)this.label5);
            this.Controls.Add((Control)this.label4);
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.button1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(Form1);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "СОРТИРАНЕ НА ЧИСЛА";
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
