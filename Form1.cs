using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPM
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonInputGenerate_Click(object sender, EventArgs e)
        {
            //String StringOfSymbols = TextBoxInput.Text;
            String StringOfSymbols = richTextBox1.Text;
            if (StringOfSymbols.Length >= 4)
            {
                char[] SymbolsArray = StringOfSymbols.ToCharArray();
                char[] SymbolsAlphabet = { 'a', 'b', 'c', 'd' };

                int[] AbortSymbolOnLevel = { 0, 0, 0, 0 };

                double[] SymbolChanceOnLevel3 = { 1, 1, 1, 1 };
                double[] SymbolChanceOnLevel2 = { 1, 1, 1, 1 };
                double[] SymbolChanceOnLevel1 = { 1, 1, 1, 1 };
                double[] SymbolChance = { 1, 1, 1, 1 };

                for (int CoddingSymbol = 0; CoddingSymbol < 4; CoddingSymbol++)
                {                    
                    bool AbortNext = false;
                    int SymbolsContextFrequence = 0; //Частота появления символов в контексте
                    int CoddingSymbolFrequence = 0;

                    // Level = 3
                    char[] Context = { SymbolsArray[StringOfSymbols.Length - 1], SymbolsArray[StringOfSymbols.Length - 2], SymbolsArray[StringOfSymbols.Length - 3] };
                    for (int ContextCoddingSymbol = 0; ContextCoddingSymbol < 4; ContextCoddingSymbol++)
                    {
                        for (int N = 0; N < StringOfSymbols.Length - 3; N++)
                        {
                            if (Context[0] == SymbolsArray[N] && Context[1] == SymbolsArray[N + 1] && Context[2] == SymbolsArray[N + 2] && SymbolsAlphabet[ContextCoddingSymbol] == SymbolsArray[N + 3])
                            {
                                if(CoddingSymbol == ContextCoddingSymbol)
                                {
                                    CoddingSymbolFrequence++;
                                    SymbolsContextFrequence++;
                                    AbortSymbolOnLevel[CoddingSymbol] = 2;
                                }
                                else
                                {
                                    SymbolsContextFrequence++;
                                }
                            }
                        }
                    }
                    if (CoddingSymbolFrequence > 0)
                    {
                        SymbolChanceOnLevel3[CoddingSymbol] *= (double)CoddingSymbolFrequence / (double)(SymbolsContextFrequence + 1);
                        AbortNext = true;
                    }
                    else
                    {
                        SymbolChanceOnLevel3[CoddingSymbol] *= 1.0 / (SymbolsContextFrequence + 1);
                    }

                    // Level =  2
                    if (AbortNext == false)
                    {
                        SymbolsContextFrequence = 0;
                        CoddingSymbolFrequence = 0;
                        Context[0] = SymbolsArray[StringOfSymbols.Length - 2];
                        Context[1] = SymbolsArray[StringOfSymbols.Length - 1];
                        for (int ContextCoddingSymbol = 0; ContextCoddingSymbol < 4; ContextCoddingSymbol++)
                        {
                            if (AbortSymbolOnLevel[ContextCoddingSymbol] < 2)
                            {
                                for (int N = 0; N < StringOfSymbols.Length - 2; N++)
                                {
                                    if (Context[0] == SymbolsArray[N] && Context[1] == SymbolsArray[N + 1] && SymbolsAlphabet[ContextCoddingSymbol] == SymbolsArray[N + 2])
                                    {
                                        if (CoddingSymbol == ContextCoddingSymbol)
                                        {
                                            CoddingSymbolFrequence++;
                                            SymbolsContextFrequence++;
                                            AbortSymbolOnLevel[CoddingSymbol] = 1;
                                        }
                                        else
                                        {
                                            SymbolsContextFrequence++;
                                        }
                                    }
                                }
                            }
                        }
                        if (CoddingSymbolFrequence > 0)
                        {
                            SymbolChanceOnLevel2[CoddingSymbol] *= (double)CoddingSymbolFrequence / (double)(SymbolsContextFrequence + 1);
                            AbortNext = true;
                        }
                        else
                        {
                            SymbolChanceOnLevel2[CoddingSymbol] *= 1.0 / (SymbolsContextFrequence + 1);
                        }
                    }

                    // Level = 1
                    if (AbortNext == false)
                    {
                        SymbolsContextFrequence = 0;
                        CoddingSymbolFrequence = 0;
                        Context[0] = SymbolsArray[StringOfSymbols.Length - 1];
                        for (int ContextCoddingSymbol = 0; ContextCoddingSymbol < 4; ContextCoddingSymbol++)
                        {
                            if (AbortSymbolOnLevel[ContextCoddingSymbol] < 1)
                            {
                                for (int N = 0; N < StringOfSymbols.Length - 1; N++)
                                {
                                    if (Context[0] == SymbolsArray[N] && SymbolsAlphabet[ContextCoddingSymbol] == SymbolsArray[N + 1])
                                    {
                                        if (CoddingSymbol == ContextCoddingSymbol)
                                        {
                                            CoddingSymbolFrequence++;
                                            SymbolsContextFrequence++;
                                            AbortSymbolOnLevel[CoddingSymbol] = 0;
                                        }
                                        else
                                        {
                                            SymbolsContextFrequence++;
                                        }
                                    }
                                }
                            }
                        }
                        if (CoddingSymbolFrequence > 0)
                        {
                            SymbolChanceOnLevel1[CoddingSymbol] *= (double)CoddingSymbolFrequence / (double)(SymbolsContextFrequence + 1);
                            AbortNext = true;
                        }
                        else
                        {
                            SymbolChanceOnLevel1[CoddingSymbol] *= 1.0 / (SymbolsContextFrequence + 1);
                        }
                    }
                }                

                // Output
                for (int N = 0; N < 4; N++)
                {
                    DataGirdView.Rows.Add(SymbolsAlphabet[N], SymbolChanceOnLevel3[N], SymbolChanceOnLevel2[N], SymbolChanceOnLevel1[N], SymbolChanceOnLevel1[N] * SymbolChanceOnLevel2[N] * SymbolChanceOnLevel3[N]);
                }
            }
        }

        private void GroupBoxInput_Enter(object sender, EventArgs e)
        {

        }
    }
}
