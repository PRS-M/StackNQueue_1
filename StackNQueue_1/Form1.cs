﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackNQueue_1
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        public Form1()
        {
            InitializeComponent();
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            int number = 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks.";
            }
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Crispy;
            else if (soggy.Checked)
                food = Flapjack.Soggy;
            else if (browned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);

            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapJacks();
            nextInLine.Text = "";
            RedrawList();
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(nameBox.Text));
            nameBox.Text = "";
            RedrawList();
        }
    }
}
