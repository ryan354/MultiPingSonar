using System;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Ping
{
    public partial class start2 : Form
    {


        public start2()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            green1.Paint += green1_Paint;
            green3.Paint += green3_Paint;
            green2.Paint += green2_Paint;
            green4.Paint += green4_Paint;
            //logoROV.Paint += logorov_Paint;
            yellow1.Paint += yellow1_Paint;
            yellow3.Paint += yellow3_Paint;
            yellow2.Paint += yellow2_Paint;
            yellow4.Paint += yellow4_Paint;
            orange1.Paint += orange1_Paint;
            orange3.Paint += orange3_Paint;
            orange2.Paint += orange2_Paint;
            orange4.Paint += orange4_Paint;
            red1.Paint += red1_Paint;
            red3.Paint += red3_Paint;
            red2.Paint += red2_Paint;
            red4.Paint += red4_Paint;
            string[] ports1 = SerialPort.GetPortNames();
            string[] ports2 = SerialPort.GetPortNames();
            string[] ports3 = SerialPort.GetPortNames();
            string[] ports4 = SerialPort.GetPortNames();
            comalt1.Items.AddRange(ports1);
            comalt2.Items.AddRange(ports2);
            comalt3.Items.AddRange(ports3);
            comalt4.Items.AddRange(ports4);



        }

        //(horizontal)
        // Version 1: transparent
        private void DrawRectangleSolidColor(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 200, 10);
        }

        // Version 2: Rectangle with gradient effect
        private void DrawRectangleWithBoldEffect(PaintEventArgs e)
        {
            // Create a rectangle with a bold border
            Rectangle rect = new Rectangle(10, 10, 200, 10);
            int borderWidth = 5; // Set the border width

            // Draw the bold border
            e.Graphics.FillRectangle(Brushes.DarkGreen, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.LightGreen, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }

        //(vertical)
        // Version 1: transparent
        private void DrawRectangleSolidColorV(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 10, 170);
        }

        // Version 2: Rectangle with gradient effect
        private void DrawRectangleWithBoldEffectV(PaintEventArgs e)
        {
            // Create a rectangle with a bold border
            Rectangle rect = new Rectangle(10, 10, 10, 170);
            int borderWidth = 5; 

            // Draw the bold border
            e.Graphics.FillRectangle(Brushes.DarkGreen, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.LightGreen, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }

        private void green1_Paint(object sender, PaintEventArgs e)
        {


            if (shij1raw == 1)
            {
                DrawRectangleSolidColor(e);     // Version 1
            }
            else if (shij1raw == 2)
            {
                DrawRectangleWithBoldEffect(e);   // Version 2
            }


        }

        private void green3_Paint(object sender, PaintEventArgs e)
        {


            if (shij3raw == 1)
            {
                DrawRectangleSolidColor(e);     // Version 1
            }
            else if (shij3raw == 2)
            {
                DrawRectangleWithBoldEffect(e);   // Version 2
            }
        }


        private void green2_Paint(object sender, PaintEventArgs e)
        {


            if (shij2raw == 1)
            {
                DrawRectangleSolidColorV(e);     // Version 1
            }
            else if (shij2raw == 2)
            {
                DrawRectangleWithBoldEffectV(e);   // Version 2
            }



        }

        private void green4_Paint(object sender, PaintEventArgs e)
        {



            if (shij4raw == 1)
            {
                DrawRectangleSolidColorV(e);     // Version 1
            }
            else if (shij4raw == 2)
            {
                DrawRectangleWithBoldEffectV(e);   // Version 2
            }
        }


        //(horizontal yellow)

        private void DrawRectangleSolidColorYH(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 170, 10);
        }

        
        private void DrawRectangleWithBoldEffectYH(PaintEventArgs e)
        {
          
            Rectangle rect = new Rectangle(10, 10, 170, 10);
            int borderWidth = 5; 

           
            e.Graphics.FillRectangle(Brushes.Yellow, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.LightYellow, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }


        //(vertical yellow)
 
        private void DrawRectangleSolidColorYV(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 10, 140);
        }

        // Version 2: Rectangle with gradient effect
        private void DrawRectangleWithBoldEffectYV(PaintEventArgs e)
        {
            // Create a rectangle with a bold border
            Rectangle rect = new Rectangle(10, 10, 10, 140);
            int borderWidth = 5; // Set the border width

            // Draw the bold border
            e.Graphics.FillRectangle(Brushes.Yellow, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.LightYellow, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }

        private void yellow1_Paint(object sender, PaintEventArgs e)
        {

            if (syel1raw == 1)
            {
                DrawRectangleSolidColorYH(e);     // Version 1
            }
            else if (syel1raw == 2)
            {
                DrawRectangleWithBoldEffectYH(e);   // Version 2
            }
        }

        private void yellow3_Paint(object sender, PaintEventArgs e)
        {


            if (syel3raw == 1)
            {
                DrawRectangleSolidColorYH(e);     // Version 1
            }
            else if (syel3raw == 2)
            {
                DrawRectangleWithBoldEffectYH(e);   // Version 2
            }
        }

        private void yellow2_Paint(object sender, PaintEventArgs e)
        {


            if (syel2raw == 1)
            {
                DrawRectangleSolidColorYV(e);     // Version 1
            }
            else if (syel2raw == 2)
            {
                DrawRectangleWithBoldEffectYV(e);   // Version 2
            }
        }

        private void yellow4_Paint(object sender, PaintEventArgs e)
        {



            if (syel4raw == 1)
            {
                DrawRectangleSolidColorYV(e);     // Version 1
            }
            else if (syel4raw == 2)
            {
                DrawRectangleWithBoldEffectYV(e);   // Version 2
            }
        }

        //(horizontal orange)
        //Version 1: transparent
        private void DrawRectangleSolidColorOH(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 120, 10);
        }
        //Version 2: Rectangle with gradient effect
        private void DrawRectangleWithBoldEffectOH(PaintEventArgs e)
        {
            // Create a rectangle with a bold border
            Rectangle rect = new Rectangle(10, 10, 120, 10);
            int borderWidth = 5; // Set the border width

            // Draw the bold border
            e.Graphics.FillRectangle(Brushes.DarkOrange, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.Orange, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }

        //(vertical orange)
        private void DrawRectangleSolidColorOV(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 10, 800);
        }

        // Version 2: Rectangle with gradient effect
        private void DrawRectangleWithBoldEffectOV(PaintEventArgs e)
        {
            // Create a rectangle with a bold border
            Rectangle rect = new Rectangle(10, 10, 10, 80);
            int borderWidth = 5; // Set the border width

            // Draw the bold border
            e.Graphics.FillRectangle(Brushes.DarkOrange, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.Orange, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }
        private void orange1_Paint(object sender, PaintEventArgs e)
        {

            if (sorg1raw == 1)
            {
                DrawRectangleSolidColorOH(e);     // Version 1
            }
            else if (sorg1raw == 2)
            {
                DrawRectangleWithBoldEffectOH(e);   // Version 2

            }
        }

        private void orange3_Paint(object sender, PaintEventArgs e)
        {



            if (sorg3raw == 1)
            {
                DrawRectangleSolidColorOH(e);     // Version 1
            }
            else if (sorg3raw == 2)
            {
                DrawRectangleWithBoldEffectOH(e);   // Version 2

            }
        }

        private void orange2_Paint(object sender, PaintEventArgs e)
        {


            if (sorg2raw == 1)
            {
                DrawRectangleSolidColorOV(e);     // Version 1
            }
            else if (sorg2raw == 2)
            {
                DrawRectangleWithBoldEffectOV(e);   // Version 2

            }

        }

        private void orange4_Paint(object sender, PaintEventArgs e)
        {



            if (sorg4raw == 1)
            {
                DrawRectangleSolidColorOV(e);     // Version 1
            }
            else if (sorg4raw == 2)
            {
                DrawRectangleWithBoldEffectOV(e);   // Version 2

            }
        }


        //(horizontal red)
        private void DrawRectangleSolidColorRH(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 70, 10);
        }

        private void DrawRectangleWithBoldEffectRH(PaintEventArgs e)
        {
            // Create a rectangle with a bold border
            Rectangle rect = new Rectangle(10, 10, 70, 10);
            int borderWidth = 5; // Set the border width

            // Draw the bold border
            e.Graphics.FillRectangle(Brushes.DarkRed, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.Red, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }

        //(vertical red)
        private void DrawRectangleSolidColorRV(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, 10, 10, 10, 50);
        }

        // Version 2: Rectangle with gradient effect
        private void DrawRectangleWithBoldEffectRV(PaintEventArgs e)
        {
            // Create a rectangle with a bold border
            Rectangle rect = new Rectangle(10, 10, 10, 50);
            int borderWidth = 5; // Set the border width

            // Draw the bold border
            e.Graphics.FillRectangle(Brushes.DarkRed, rect);
            e.Graphics.DrawRectangle(new Pen(Brushes.Red, borderWidth), rect.X, rect.Y, rect.Width, rect.Height);
        }

        private void red1_Paint(object sender, PaintEventArgs e)
        {

        
            if (sred1raw == 1)
            {
                DrawRectangleSolidColorRH(e);     // Version 1
            }
            else if (sred1raw == 2)
            {
                DrawRectangleWithBoldEffectRH(e);   // Version 2
            }
        }

        
        
        
        private void red3_Paint(object sender, PaintEventArgs e)
        {

            if (sred3raw == 1)
            {
                DrawRectangleSolidColorRH(e);     // Version 1
            }
            else if (sred3raw == 2)
            {
                DrawRectangleWithBoldEffectRH(e);   // Version 2
            }
        }

        private void red2_Paint(object sender, PaintEventArgs e)
        {

            if (sred2raw == 1)
            {
                DrawRectangleSolidColorRV(e);     // Version 1
            }
            else if (sred2raw == 2)
            {
                DrawRectangleWithBoldEffectRV(e);   // Version 2
            }
        }

        private void red4_Paint(object sender, PaintEventArgs e)
        {


            if (sred4raw == 1)
            {
                DrawRectangleSolidColorRV(e);     // Version 1
            }
            else if (sred4raw == 2)
            {
                DrawRectangleWithBoldEffectRV(e);   // Version 2
            }

        }



        // Ports setting


        private void comalt1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comalt2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comalt3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comalt4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }








        //parse here

        private void ProcessBytes(byte[] data, int stdLen, int prcNum)
        {
            byte[] stStr = { 0x42, 0x52 }; // [B][R]

            if (stdLen <= data.Length)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    int sumLen = data.Length;
                    if (stStr[0] == data[i]) // Start Bit[42]
                    {
                        if (stdLen <= sumLen - i)
                        {
                            if (stStr[1] == data[i + 1]) // Start Bit[52]
                            {
                                
                                int iLen = 0;

                                // Check if there are enough bytes available before accessing array elements
                                if (i + 3 < data.Length && i + 2 < data.Length)
                                {
                                    byte[] dataLen = { data[i + 3], data[i + 2] };

                                    // Specify big.endian order
                                    iLen = BitConverter.ToInt16(dataLen.Reverse().ToArray(), 0);

                                    //Console.WriteLine($"Payload Length: {iLen}");
                                }
                                else
                                {
                                    //Console.WriteLine("[ Insufficient bytes for dataLen ]");
                                    break; // Exit the loop if there are not enough bytes
                                }

                                int ttlLen = iLen + stdLen - 1; // Excluding Payload Count
                                if (ttlLen <= sumLen - i)
                                {
                                    uint iHtI = 0;
                                    uint iCheckSum = 0;
                                    int iCheckSumL = 0;

                                    // ...
                                    for (int j = i; j < i + ttlLen - 2 && j < data.Length; j++) // Checksum, process one byte at a time
                                    {
                                        iHtI = data[j]; // Use the byte directly
                                        iCheckSum += iHtI;
                                        iCheckSumL = j;

                                        // Debug prints
                                        //Console.Write($"data[{j}]: {data[j]:X2} ");
                                        //Console.WriteLine($"iHtI: 00{iHtI:X2}");
                                    }


                                    if (iCheckSumL + 2 < data.Length && iCheckSumL + 1 < data.Length)
                                    {
                                        ushort checksumLenValue = (ushort)((data[iCheckSumL + 2] << 8) | data[iCheckSumL + 1]);
                                        iLen = checksumLenValue;

                                        // Debug prints
                                        //Console.WriteLine($"Checksum Length: {iLen}");
                                    }
                                    else
                                    {
                                        //Console.WriteLine("[ Insufficient bytes for checksumLen ]");
                                        break; // Exit the loop if there are not enough bytes
                                    }


                                    if (iCheckSum == iLen) // Parsing...............................
                                    {

                                        int iGab = 3;

                                        //Console.WriteLine("Checksum matched!!");
                                        //Console.WriteLine("iLen == iCheckSum: {0} - {1}", iLen, iCheckSum);

                                        if (data.Length >= 6) // Ensure strSum has at least 6 elements
                                        {
                                            if (data[4] == 0x04 && data[5] == 0x00) // general_request
                                            {

                                                //Console.WriteLine("Read Message : General_request");
                                                //Console.WriteLine($"type : {data[8]}");
                                                if (data[8] == 1)
                                                {

                                                    MessageBox.Show("Device Type : Ping 1D Echosounder", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    //Console.WriteLine("ping 1D");
                                                    
                                                }
                                                else
                                                {

                                                    //Console.WriteLine("Device Type: Unknown");
                                                }

                                            }
                                            else if (data[4] == 0xBC && data[5] == 0x04) // distance
                                            {

                                                //Console.WriteLine("Read Message : Distance");
                                                proc_Distance(data, prcNum);
                                            }
                                            else if (data[4] == 0xBB && data[5] == 0x04) // distance_simple
                                            {
                                                //Console.WriteLine("Read Message : Distance_simple");
                                                proc_Distance(data, prcNum);

                                            }
                                            else if (data[4] == 0x14 && data[5] == 0x05) // profile
                                            {
                                                //Console.WriteLine("Read Message : Profile");
                                                proc_Distance(data, prcNum);
                                            }
                                            else
                                            {
                                                //Console.WriteLine("Unknown Message");
                                            }
                                        }
                                        else
                                        {
                                            //Console.WriteLine("Data does not have enough elements for parsing.");
                                        }

                                        // If there is remaining data, remove the processed part and reset loop variables
                                        byte[] newData = new byte[data.Length - (iCheckSumL + iGab)];
                                        Array.Copy(data, iCheckSumL + iGab, newData, 0, newData.Length);
                                        data = newData;
                                        i = -1;
                                        continue;


                                    }
                                    else
                                    {
                                        //Console.WriteLine("[ Fail Check Sum !!!] iLen: {0} - {1}", iLen, iCheckSum);
                                    }
                                }
                                else
                                {
                                    //Console.WriteLine("[ Short Length for Check Sum !!! ]");
                                }
                            }
                        }
                    }
                }
            }
        }

        //1st alt param safety distance
        private int sred1raw = 1;
        private int sorg1raw = 1;
        private int syel1raw = 1;
        private int shij1raw = 1;

        //2nd alt param safety distance
        private int sred2raw = 1;
        private int sorg2raw = 1;
        private int syel2raw = 1;
        private int shij2raw = 1;

        //3rd alt param safety distance
        private int sred3raw = 1;
        private int sorg3raw = 1;
        private int syel3raw = 1;
        private int shij3raw = 1;

        //4th alt param safety distance
        private int sred4raw = 1;
        private int sorg4raw = 1;
        private int syel4raw = 1;
        private int shij4raw = 1;

        void updatesafety(int confi, double distance, double redsafetyvalue, double orangesafetyvalue, double yellowsafetyvalue, double greensafetyvalue, ref int sred, ref int sorg, ref int syel, ref int shij, string altMessage)
        {
            if (confi > 70)
            {
                if (distance > redsafetyvalue && distance > orangesafetyvalue && distance > yellowsafetyvalue && distance > greensafetyvalue)
                {
                    sred = 2;
                    sorg = 2;
                    syel = 2;
                    shij = 2;
                }
                else if (distance > redsafetyvalue && distance > orangesafetyvalue && distance > yellowsafetyvalue)
                {
                    sred = 2;
                    sorg = 2;
                    syel = 2;
                    shij = 1;
                }
                else if (distance > redsafetyvalue && distance > orangesafetyvalue)
                {
                    sred = 2;
                    sorg = 2;
                    syel = 1;
                    shij = 1;
                }
                else if (distance > redsafetyvalue)
                {
                    sred = 2;
                    sorg = 1;
                    syel = 1;
                    shij = 1;
                }
                else
                {
                    sred = 2;
                    sorg = 1;
                    syel = 1;
                    shij = 1;
                }
            }
            else
            {
                sred = 1;
                sorg = 1;
                syel = 1;
                shij = 1;
                Console.WriteLine($"Confidance {altMessage} is low");
            }
        }

        private void proc_Distance(byte[] data, int prcNum)
        {
            try
            {
                // Ensure that data has enough elements

                byte[] distBytes = { data[8], data[9], data[10], data[11] };
                byte[] conByt = { data[12], data[13] };

                // Print distBytes to console
                /*
                Console.Write("distBytes: ");
                foreach (byte b in distBytes)
                {
                    Console.Write($"{b:X2} ");
                }
                */                      

              


                int number1 = BitConverter.ToInt32(distBytes, 0);
                float distance = number1 / 1000.0f;


                int confi = BitConverter.ToInt16(conByt, 0);

                if (prcNum == 1)
                {
                    //Console.WriteLine($"Serial 1: Distance - {distance} m");
                    //Console.WriteLine($"Serial 1: Confidence - {confi} %");
                    UpdateDistanceLabel1(distance);
                    UpdateConfidenceLabel1(confi);
                    updatesafety(confi, distance, redsafetyvalue, orangesafetyvalue, yellowsafetyvalue, greensafetyvalue, ref sred1raw, ref sorg1raw, ref syel1raw, ref shij1raw, "1st Alt");
                    red1.Invalidate();
                    orange1.Invalidate();
                    yellow1.Invalidate();
                    green1.Invalidate();

                }
                else if (prcNum == 2)
                {

                    //Console.WriteLine($"Serial 2: Distance - {distance}");
                    //Console.WriteLine($"Serial 2: Confidence - {confi} %");
                    UpdateDistanceLabel2(distance);
                    UpdateConfidenceLabel2(confi);
                    updatesafety(confi, distance, redsafetyvalue, orangesafetyvalue, yellowsafetyvalue, greensafetyvalue, ref sred2raw, ref sorg2raw, ref syel2raw, ref shij2raw, "2nd Alt");
                    red2.Invalidate();
                    orange2.Invalidate();
                    yellow2.Invalidate();
                    green2.Invalidate();


                }
                else if (prcNum == 3)
                {

                    //Console.WriteLine($"Serial 3: Distance - {distance}");
                    //Console.WriteLine($"Serial 3: Confidence - {confi} %");
                    UpdateDistanceLabel3(distance);
                    UpdateConfidenceLabel3(confi);
                    updatesafety(confi, distance, redsafetyvalue, orangesafetyvalue, yellowsafetyvalue, greensafetyvalue, ref sred3raw, ref sorg3raw, ref syel3raw, ref shij3raw, "3rd Alt");
                    red3.Invalidate();
                    orange3.Invalidate();
                    yellow3.Invalidate();
                    green3.Invalidate();




                }
                else if (prcNum == 4)
                {

                    //Console.WriteLine($"Serial 4: Distance - {distance}");
                    //Console.WriteLine($"Serial 4: Confidence - {confi} %");
                    UpdateDistanceLabel4(distance);
                    UpdateConfidenceLabel4(confi);
                    updatesafety(confi, distance, redsafetyvalue, orangesafetyvalue, yellowsafetyvalue, greensafetyvalue, ref sred4raw, ref sorg4raw, ref syel4raw, ref shij4raw, "4th Alt");
                    red4.Invalidate();
                    orange4.Invalidate();
                    yellow4.Invalidate();
                    green4.Invalidate();

                }
                else
                {
                    Console.WriteLine($"Serial id unrecognized");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in proc_Distance: {ex.Message}");
            }
        }





        private void UpdateDistanceLabel1(float dynamicValue)
        {
            if (distance1.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateDistanceLabel1), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                distance1.Text = dynamicValue.ToString("F2");
            }
        }

        private void UpdateConfidenceLabel1(float dynamicValue)
        {
            if (confidence1.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateConfidenceLabel1), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                confidence1.Text = dynamicValue.ToString();
            }
        }


        private void UpdateDistanceLabel2(float dynamicValue)
        {
            if (distance2.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateDistanceLabel2), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                distance2.Text = dynamicValue.ToString("F2");
            }
        }

        private void UpdateConfidenceLabel2(float dynamicValue)
        {
            if (confidence2.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateConfidenceLabel2), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                confidence2.Text = dynamicValue.ToString();
            }
        }
        private void UpdateDistanceLabel3(float dynamicValue)
        {
            if (distance3.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateDistanceLabel3), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                distance3.Text = dynamicValue.ToString("F2");
            }
        }

        private void UpdateConfidenceLabel3(float dynamicValue)
        {
            if (confidence3.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateConfidenceLabel3), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                confidence3.Text = dynamicValue.ToString();
            }
        }



        private void UpdateDistanceLabel4(float dynamicValue)
        {
            if (distance4.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateDistanceLabel4), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                distance4.Text = dynamicValue.ToString("F2");
            }
        }

        private void UpdateConfidenceLabel4(float dynamicValue)
        {
            if (confidence4.InvokeRequired)
            {
                // If the current thread is not the UI thread, invoke the method on the UI thread.
                this.Invoke(new Action<float>(UpdateConfidenceLabel4), dynamicValue);
            }
            else
            {
                // Update the label on the UI thread.
                confidence4.Text = dynamicValue.ToString();
            }
        }










        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e, System.Windows.Forms.TextBox consoleDisplay)
        {
            try
            {
                // Read all available bytes from the serial port
                int bytesToRead = serialPort1.BytesToRead;
                byte[] receivedBytes = new byte[bytesToRead];
                int bytesRead = serialPort1.Read(receivedBytes, 0, bytesToRead);

                if (bytesRead > 0)
                {
                    // Convert the received bytes to a hex string
                    string receivedData = BitConverter.ToString(receivedBytes, 0, bytesRead).Replace("-", " ");

                    // Display the received data in consoledisplay
                    /*
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        consoleDisplay.AppendText($"Received Data: {receivedData}{Environment.NewLine}");
                    });
                    
                    // Make sure the timestamp is also updated on the UI thread
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        proc_TimeStamp();
                    });
                    */
                    ProcessBytes(receivedBytes, 11, 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DataReceived event: {ex.Message}");
            }
        }

        private void SerialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e, System.Windows.Forms.TextBox consoleDisplay)
        {
            try
            {
                // Read all available bytes from the serial port
                int bytesToRead = serialPort2.BytesToRead;
                byte[] receivedBytes = new byte[bytesToRead];
                int bytesRead = serialPort2.Read(receivedBytes, 0, bytesToRead);

                if (bytesRead > 0)
                {
                    // Convert the received bytes to a hex string
                    string receivedData = BitConverter.ToString(receivedBytes, 0, bytesRead).Replace("-", " ");

                    // Display the received data in consoledisplay
                    /*
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        consoleDisplay.AppendText($"Received Data: {receivedData}{Environment.NewLine}");
                    });
                    
                    // Make sure the timestamp is also updated on the UI thread
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        proc_TimeStamp();
                    });
                    */
                    ProcessBytes(receivedBytes, 11, 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DataReceived event: {ex.Message}");
            }
        }

        private void SerialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e, System.Windows.Forms.TextBox consoleDisplay)
        {
            try
            {
                // Read all available bytes from the serial port
                int bytesToRead = serialPort3.BytesToRead;
                byte[] receivedBytes = new byte[bytesToRead];
                int bytesRead = serialPort3.Read(receivedBytes, 0, bytesToRead);

                if (bytesRead > 0)
                {
                    // Convert the received bytes to a hex string
                    string receivedData = BitConverter.ToString(receivedBytes, 0, bytesRead).Replace("-", " ");

                    // Display the received data in consoledisplay
                    /*
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        consoleDisplay.AppendText($"Received Data: {receivedData}{Environment.NewLine}");
                    });
                    
                    // Make sure the timestamp is also updated on the UI thread
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        proc_TimeStamp();
                    });
                    */
                    ProcessBytes(receivedBytes, 11, 3);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DataReceived event: {ex.Message}");
            }
        }

        private void SerialPort4_DataReceived(object sender, SerialDataReceivedEventArgs e, System.Windows.Forms.TextBox consoleDisplay)
        {
            try
            {
                // Read all available bytes from the serial port
                int bytesToRead = serialPort4.BytesToRead;
                byte[] receivedBytes = new byte[bytesToRead];
                int bytesRead = serialPort4.Read(receivedBytes, 0, bytesToRead);

                if (bytesRead > 0)
                {
                    // Convert the received bytes to a hex string
                    string receivedData = BitConverter.ToString(receivedBytes, 0, bytesRead).Replace("-", " ");

                    // Display the received data in consoledisplay
                    /*
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        consoleDisplay.AppendText($"Received Data: {receivedData}{Environment.NewLine}");
                    });
                    
                    // Make sure the timestamp is also updated on the UI thread
                    consoleDisplay.Invoke((MethodInvoker)delegate
                    {
                        proc_TimeStamp();
                    });
                    */
                    ProcessBytes(receivedBytes, 11, 4);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DataReceived event: {ex.Message}");
            }
        }





        private void connectalt1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comalt1.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudalt1.Text);
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Open();
                bar1.Value = 100;
                consoledisplay.AppendText($"1st Sensor Connected to {serialPort1.PortName} at {serialPort1.BaudRate} baud rate.{Environment.NewLine}");
                proc_TimeStamp();
                serialPort1.DataReceived += (s, ev) => SerialPort1_DataReceived(s, ev, consoledisplay);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void connectalt2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort2.PortName = comalt2.Text;
                serialPort2.BaudRate = Convert.ToInt32(baudalt2.Text);
                serialPort2.DataBits = 8;
                serialPort2.Parity = Parity.None;
                serialPort2.StopBits = StopBits.One;
                serialPort2.Handshake = Handshake.None;
                serialPort2.Open();
                bar2.Value = 100;
                consoledisplay.AppendText($"2nd Sensor Connected to {serialPort2.PortName} at {serialPort2.BaudRate} baud rate.{Environment.NewLine}");
                proc_TimeStamp();
                serialPort2.DataReceived += (s, ev) => SerialPort2_DataReceived(s, ev, consoledisplay);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void connectalt3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort3.PortName = comalt3.Text;
                serialPort3.BaudRate = Convert.ToInt32(baudalt3.Text);
                serialPort3.DataBits = 8;
                serialPort3.Parity = Parity.None;
                serialPort3.StopBits = StopBits.One;
                serialPort3.Handshake = Handshake.None;
                serialPort3.Open();
                bar3.Value = 100;
                consoledisplay.AppendText($"3rd Sensor Connected to {serialPort3.PortName} at {serialPort3.BaudRate} baud rate.{Environment.NewLine}");
                proc_TimeStamp();
                serialPort3.DataReceived += (s, ev) => SerialPort3_DataReceived(s, ev, consoledisplay);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void connectalt4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort4.PortName = comalt4.Text;
                serialPort4.BaudRate = Convert.ToInt32(baudalt4.Text);
                serialPort4.DataBits = 8;
                serialPort4.Parity = Parity.None;
                serialPort4.StopBits = StopBits.One;
                serialPort4.Handshake = Handshake.None;
                serialPort4.Open();
                bar4.Value = 100;
                consoledisplay.AppendText($"4th Sensor Connected to {serialPort4.PortName} at {serialPort4.BaudRate} baud rate.{Environment.NewLine}");
                proc_TimeStamp();
                serialPort4.DataReceived += (s, ev) => SerialPort4_DataReceived(s, ev, consoledisplay);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RefreshSerialPorts()
        {
            // Clear existing items
            comalt1.Items.Clear();
            comalt2.Items.Clear();
            comalt3.Items.Clear();
            comalt4.Items.Clear();

            // Get and add new port names
            string[] ports1 = SerialPort.GetPortNames();
            string[] ports2 = SerialPort.GetPortNames();
            string[] ports3 = SerialPort.GetPortNames();
            string[] ports4 = SerialPort.GetPortNames();

            comalt1.Items.AddRange(ports1);
            comalt2.Items.AddRange(ports2);
            comalt3.Items.AddRange(ports3);
            comalt4.Items.AddRange(ports4);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshSerialPorts();
        }


        private void close1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                bar1.Value = 0;
                consoledisplay.AppendText($"Serial port closed.{Environment.NewLine}");

            }
            else
            {
                MessageBox.Show("Serial port is already closed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void close2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                bar2.Value = 0;
                consoledisplay.AppendText($"Serial port closed.{Environment.NewLine}");

            }
            else
            {
                MessageBox.Show("Serial port is already closed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void close3_Click(object sender, EventArgs e)
        {
            if (serialPort3.IsOpen)
            {
                serialPort3.Close();
                bar3.Value = 0;
                consoledisplay.AppendText($"Serial port closed.{Environment.NewLine}");

            }
            else
            {
                MessageBox.Show("Serial port is already closed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void close4_Click(object sender, EventArgs e)
        {
            if (serialPort4.IsOpen)
            {
                serialPort4.Close();
                bar4.Value = 0;
                consoledisplay.AppendText($"Serial port closed.{Environment.NewLine}");

            }
            else
            {
                MessageBox.Show("Serial port is already closed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

  




        private void baudalt2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baudalt3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void baudalt4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proc_TimeStamp()
        {
            DateTime now = DateTime.Now;
            string strDate = now.ToString("yyyyMMdd");
            string strTime = now.ToString("HH:mm:ss:fff");

            string m_strFull = $"{strDate}, {strTime}";
            //Console.WriteLine(m_strFull);
            consoledisplay.AppendText(m_strFull + Environment.NewLine);

        }

        //convert Hex to array
        private byte[] HexStringToByteArray(string hexString)
        {
            try
            {
                // Remove leading and trailing spaces and split by space
                string[] hexValues = hexString.Trim().Split(' ');

                // Filter out empty strings
                hexValues = hexValues.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

                // Convert each hex value to byte
                return hexValues.Select(s => Convert.ToByte(s, 16)).ToArray();
            }
            catch (FormatException ex)
            {
                // Handle format exception (e.g., invalid hex format)
                Console.WriteLine($"Error in HexStringToByteArray: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Error in HexStringToByteArray: {ex.Message}");
            }

            // Return an empty byte array or handle the error as appropriate for your application
            return Array.Empty<byte>();
        }





        //get device info


        private void getdeviceinfo(SerialPort serialPort)
        {
            string hexData = "42 52 02 00 06 00 00 00 04 00 A0 00";
            if (serialPort.IsOpen)
            {
                // Generate timestamp
                proc_TimeStamp();

                // Send Hex data
                serialPort.DiscardInBuffer();
                byte[] byteArray = HexStringToByteArray(hexData);
                serialPort.Write(byteArray, 0, byteArray.Length);
                DisplaySentData(hexData);
                Thread.Sleep(100);


            }
        }

        private void info1_Click(object sender, EventArgs e)
        {
            getdeviceinfo(serialPort1);
        }


        private void info2_Click(object sender, EventArgs e)
        {
            getdeviceinfo(serialPort2);
        }

        private void info3_Click(object sender, EventArgs e)
        {
            getdeviceinfo(serialPort3);
        }

        private void info4_Click(object sender, EventArgs e)
        {
            getdeviceinfo(serialPort4);
        }




        private void DisplaySentData(string data)
        {
            // Display sent data in textbox
            consoledisplay.AppendText($"Sent: {data}{Environment.NewLine}");
        }

        private void cleardisplay_Click(object sender, EventArgs e)
        {
            consoledisplay.Clear();
        }


        //get distance and conf
        private bool WriteDistance(SerialPort serialPort, string sId)
        {
            if (serialPort.IsOpen)
            {
                // Prepare Hex data
                string hexData = "42 52 00 00 BC 04 00";
                byte[] byteArray = HexStringToByteArray(hexData);

                // Append additional data based on sId
                if (sId == "0")
                {
                    string dstDeviceId = "00 54 01";
                    byteArray = byteArray.Concat(HexStringToByteArray(dstDeviceId)).ToArray();
                }

                // Send the Hex data
                serialPort.Write(byteArray, 0, byteArray.Length);

                // Display sent data
                string sentData = BitConverter.ToString(byteArray).Replace("-", " ");
                //DisplaySentData(sentData);

                return true;
            }
            else
            {
                //Console.WriteLine($"Failed to open the port for sID: {sId}");
                return false;
            }
        }


        private async void StartSerialOperation(SerialPort serialPort, CancellationTokenSource cancellationTokenSource, Button startButton)
        {
            int delayMilliseconds = 150; // update data


            while (serialPort.IsOpen)
            {
                WriteDistance(serialPort, "0");

                // Wait for the specified delay before sending the next request
                await Task.Delay(delayMilliseconds);

                // Check if cancellation is requested
                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    break;
                }
            }


        }

        private void StopSerialOperation(CancellationTokenSource cancellationTokenSource, Button startButton)
        {
            // Request cancellation to stop the loop

            cancellationTokenSource?.Cancel();
        }



        private CancellationTokenSource cancellationTokenSource1;
        private void start1_Click_1(object sender, EventArgs e)
        {
            start1st.Enabled = false;
            cancellationTokenSource1 = new CancellationTokenSource();
            StartSerialOperation(serialPort1, cancellationTokenSource1, start1st);
        }

        private void stop1_Click(object sender, EventArgs e)
        {
            start1st.Enabled = true;
            StopSerialOperation(cancellationTokenSource1, start1st);
        }



        private CancellationTokenSource cancellationTokenSource2;
        private void start2nd_Click(object sender, EventArgs e)
        {
            start2nd.Enabled = false;
            cancellationTokenSource2 = new CancellationTokenSource();
            StartSerialOperation(serialPort2, cancellationTokenSource2, start2nd);
        }

        private void stop2_Click(object sender, EventArgs e)
        {
            start2nd.Enabled = true;
            StopSerialOperation(cancellationTokenSource2, start2nd);
        }




        private CancellationTokenSource cancellationTokenSource3;
        private void start3_Click(object sender, EventArgs e)
        {
            start3.Enabled = false;
            cancellationTokenSource3 = new CancellationTokenSource();
            StartSerialOperation(serialPort3, cancellationTokenSource3, start3);
        }


        private void stop3_Click(object sender, EventArgs e)
        {
            start3.Enabled = true;
            StopSerialOperation(cancellationTokenSource3, start3);
        }









        private CancellationTokenSource cancellationTokenSource4;
        private void start4_Click(object sender, EventArgs e)
        {
            start4.Enabled = false;
            cancellationTokenSource4 = new CancellationTokenSource();
            StartSerialOperation(serialPort4, cancellationTokenSource4, start4);
        }

        private void stop4_Click(object sender, EventArgs e)
        {
            start4.Enabled = true;
            StopSerialOperation(cancellationTokenSource4, start4);
        }




        private void proc_CommonWrite(string hexData)
        {
            byte[] input = HexStringToByteArray(hexData);

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(input, 0, input.Length);
                //Console.WriteLine($"Write [1 Alt] : {hexData}");
            }
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(input, 0, input.Length);
                //Console.WriteLine($"Write [2 Alt] : {hexData}");
            }
            if (serialPort3.IsOpen)
            {
                serialPort3.Write(input, 0, input.Length);
                //Console.WriteLine($"Write [3 Alt] : {hexData}");
            }
            if (serialPort4.IsOpen)
            {
                serialPort4.Write(input, 0, input.Length);
                //Console.WriteLine($"Write [4 Alt] : {hexData}");
            }

        }

        private void contstart_Click(object sender, EventArgs e)
        {
            stop1.Enabled = false;
            start1st.Enabled = false;
            stop2.Enabled = false;
            start2nd.Enabled = false;
            stop3.Enabled = false;
            start3.Enabled = false;
            stop4.Enabled = false;
            start4.Enabled = false;

            string conthex = "42 52 02 00 78 05 00 00 14 05 2C 01";
            proc_CommonWrite(conthex);

        }

        private void contstop_Click(object sender, EventArgs e)
        {
            stop1.Enabled = true;
            start1st.Enabled = true;
            stop2.Enabled = true;
            start2nd.Enabled = true;
            stop3.Enabled = true;
            start3.Enabled = true;
            stop4.Enabled = true;
            start4.Enabled = true;
            string stophex = "42 52 02 00 79 05 00 00 14 05 2D 01";
            proc_CommonWrite(stophex);
        }


        private string simplehex = "";
        private void simple_CheckedChanged(object sender, EventArgs e)
        {
            if (simple.Checked)
            {
                simplehex = "42 52 00 00 BB 04 00 00 53 01";
                //Console.WriteLine($"Simple distance hex : {simplehex}");
            }
            else
            {

                simplehex = "";
                //Console.WriteLine($"Write : {simplehex}");
            }
        }


        private string enhex = "";
        private void enable_CheckedChanged_1(object sender, EventArgs e)
        {
            if (enable.Checked)
            {
                enhex = "42 52 01 00 EE 03 00 00 01 87 01";
                //Console.WriteLine($"Ping Enable : {enhex}");
            }
            else
            {

                enhex = "42 52 01 00 EE 03 00 00 00 86 01"; 
                //Console.WriteLine($"Ping Disable : {enhex}");
            }
        }



       

        private string distancehex = "";
        private void distance_CheckedChanged(object sender, EventArgs e)
        {
            if (distance.Checked)
            {
                distancehex = "42 52 00 00 BC 04 00 00 54 01";
                //Console.WriteLine($"Distance hex : {distancehex}");
            }
            else
            {

                distancehex = "";
                //Console.WriteLine($"Write : {distancehex}");
            }
        }


        private string mode = "";

        private void auto_CheckedChanged(object sender, EventArgs e)
        {
            if (auto.Checked)
            {
                mode = "42 52 01 00 EB 03 00 00 01 84 01";
                //Console.WriteLine($"set mode: Auto {mode}");
                gain.Enabled = false;
                range.Enabled = false;
            }
        }

        private void manual_CheckedChanged(object sender, EventArgs e)
        {
            if (manual.Checked)
            {
                mode = "42 52 01 00 EB 03 00 00 00 83 01";
                //Console.WriteLine($"set mode: Manual {mode}");
                gain.Enabled = true;
                range.Enabled = true;
            }
        }





        private void range_ValueChanged(object sender, EventArgs e)
        {
            int selectedValue = range.Value;
            string hexData;
            if (selectedValue <= 1)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 E8 03 00 00 73 02";
                proc_CommonWrite(hexData);

                //Console.WriteLine("set_range : 0 ~ 1,000mm");
            }
            else if (selectedValue <= 2)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 D0 07 00 00 5F 02";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 2,000mm");
            }
            else if (selectedValue <= 3)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 B8 0B 00 00 4B 02";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 3,000mm");
            }
            else if (selectedValue <= 4)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 A0 0F 00 00 37 02";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 4,000mm");
            }
            else if (selectedValue <= 5)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 88 13 00 00 23 02";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 5,000mms");
            }
            else if (selectedValue <= 6)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 58 1B 00 00 FB 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 7,000mm");
            }
            else if (selectedValue <= 7)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 10 27 00 00 BF 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 10,000mm");
            }
            else if (selectedValue <= 8)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 20 4E 00 00 F6 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 20,000mm");
            }
            else if (selectedValue <= 9)
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 30 75 00 00 2D 02";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 30,000mm");
            }
            else
            {
                hexData = "42 52 08 00 E9 03 00 00 00 00 00 00 50 C3 00 00 9B 02";
                proc_CommonWrite(hexData);
                //Console.WriteLine("set_range : 0 ~ 50,000mm");
            }
        }

        private void gain_ValueChanged(object sender, EventArgs e)
        {
            int selectedValue = gain.Value;
            string hexData;
            if (selectedValue <= 0)
            {
                hexData = "42 52 01 00 ED 03 00 00 00 85 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is equal to 0.6 gain");
            }
            else if (selectedValue <= 1)
            {
                hexData = "42 52 01 00 ED 03 00 00 01 86 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is equal to 1.8 gain");
            }
            else if (selectedValue <= 2)
            {
                hexData = "42 52 01 00 ED 03 00 00 02 87 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is  equal to 2 gain");
            }
            else if (selectedValue <= 3)
            {
                hexData = "42 52 01 00 ED 03 00 00 03 88 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is  equal to 3 gain");
            }
            else if (selectedValue <= 4)
            {
                hexData = "42 52 01 00 ED 03 00 00 04 89 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is  equal to 4 gain");
            }
            else if (selectedValue <= 5)
            {
                hexData = "42 52 01 00 ED 03 00 00 05 8A 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is  equal to 5 gain");
            }
            else
            {
                hexData = "42 52 01 00 ED 03 00 00 06 8B 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is greater than 6 gain");
            }
        }
        private void interval_ValueChanged(object sender, EventArgs e)
        {
            int selectedValue = interval.Value;
            string hexData;
            if (selectedValue <= 1)
            {
                hexData = "42 52 02 00 EC 03 00 00 21 00 A6 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is less than or equal to 33 ms");
            }
            else if (selectedValue <= 2)
            {
                hexData = "42 52 02 00 EC 03 00 00 32 00 B7 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value  equal to 50 ms");
            }
            else if (selectedValue <= 3)
            {
                hexData = "42 52 02 00 EC 03 00 00 64 00 E9 01";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is  equal to 100 ms");
            }

            else
            {
                hexData = "42 52 02 00 EC 03 00 00 E8 03 70 02";
                proc_CommonWrite(hexData);
                //Console.WriteLine("Selected value is greater than 1000 ms");
            }
        }





        private void setping_Click(object sender, EventArgs e)
        {
            string hexData = enhex + " " + mode + " " + " " + simplehex + " " + distancehex;
            //Console.WriteLine($"set ping : {hexData}");
            proc_CommonWrite(hexData);
        }



        private double redsafetyvalue = 0;//inititate safety distance value
        private void safetyred1_CheckedChanged(object sender, EventArgs e)
        {
            if (safetyred1.Checked)
            {
                redsafetyvalue = 0.2;
                //Console.WriteLine($"Red Safety value {redsafetyvalue}");
            }
        }

        private void safetyred2_CheckedChanged(object sender, EventArgs e)
        {
            if (safetyred2.Checked)
            {
                redsafetyvalue = 0.4;
                //Console.WriteLine($"Red Safety value {redsafetyvalue}");
            }
        }


        private double orangesafetyvalue = 0;
        private void safetyorange1_CheckedChanged(object sender, EventArgs e)
        {
            if (safetyorange1.Checked)
            {
                orangesafetyvalue = 0.6;
                //Console.WriteLine($"orange Safety value {orangesafetyvalue}");
            }
        }

        private void safetyorange2_CheckedChanged(object sender, EventArgs e)
        {
            if (safetyorange2.Checked)
            {
                orangesafetyvalue = 0.8;
                //Console.WriteLine($"orange Safety value {orangesafetyvalue}");
            }

        }

        private double yellowsafetyvalue = 0;
        private void safetyyellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (safetyyellow1.Checked)
            {
                yellowsafetyvalue = 1;
                //Console.WriteLine($"yellow Safety value {yellowsafetyvalue}");
            }
        }

        private void safetyyellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (safetyyellow2.Checked)
            {
                yellowsafetyvalue = 1.5;
                //Console.WriteLine($"yellow Safety value {yellowsafetyvalue}");
            }
        }



        private double greensafetyvalue = 0;
        private void safetygreen1_CheckedChanged(object sender, EventArgs e)
        {
            if (safetygreen1.Checked)
            {
                greensafetyvalue = 2;
                //Console.WriteLine($"green Safety value {greensafetyvalue}");
            }
        }

        private void safetygreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (safetygreen2.Checked)
            {
                greensafetyvalue = 3;
                //Console.WriteLine($"green Safety value {greensafetyvalue}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            SerialPort[] serialPorts = { serialPort1, serialPort2, serialPort3, serialPort4 };
            foreach (var port in serialPorts)
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
            }


        }


    }

}
