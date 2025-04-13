using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Diagnostics;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using System.IO;
using Guna.UI2.HtmlRenderer.Adapters;
using System.Windows.Media;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
namespace HotelManagementSystem.Classes
{
    internal class clsOtils
    {
        public static void MoveToMe(Panel pnlJumper, Guna2Button btn,Panel continer)
        {
            continer.Controls.Add(pnlJumper);
            pnlJumper.BackColor = System.Drawing.Color.FromArgb(235, 40, 60);
            pnlJumper.Size = new System.Drawing.Size(btn.Size.Width-20, 3);
            pnlJumper.Top = btn.Bottom-3;
            pnlJumper.Left = btn.Left+10;
            pnlJumper.BringToFront();
            pnlJumper.Visible = true;
        }
        static Panel ExpandedContainer = null;
        static readonly Size _MenuButtonSize = new Size(257, 45);
        static readonly int AnimationSpeed = 3;
        static readonly int TimerInterval = 10;
        static Timer resizeTimer = new Timer { Interval = TimerInterval };
        static Panel targetPanel = null;
        static bool expanding = false;

        static public void ExpandSideBarButtonStatus(Panel container)
        {
            if (container == ExpandedContainer) return; // Already expanded

            if (ExpandedContainer != null)
            {
                ResetSideBarButtonStatus(() =>
                {
                    ExpandedContainer = null; // Ensure it's reset before expanding a new one
                    StartExpanding(container);
                });
            }
            else
            {
                StartExpanding(container);
            }
        }

        static void StartExpanding(Panel container)
        {
            targetPanel = container;
            expanding = true;

            resizeTimer.Tick -= ResizeTick; // Remove any existing event handlers
            resizeTimer.Tick += ResizeTick;
            resizeTimer.Start();

            ExpandedContainer = container; // Assign after expansion starts
        }

        static public void ResetSideBarButtonStatus(Action onCollapsed = null)
        {
            if (ExpandedContainer == null)
            {
                onCollapsed?.Invoke();
                return;
            }

            targetPanel = ExpandedContainer;
            expanding = false;

            resizeTimer.Tick -= ResizeTick;
            resizeTimer.Tick += ResizeTick;
            resizeTimer.Start();

            resizeTimer.Tick += (s, e) =>
            {
                if (ExpandedContainer == null)
                {
                    onCollapsed?.Invoke();
                }
            };
        }

        static void ResizeTick(object sender, EventArgs e)
        {
            if (targetPanel == null)
            {
                resizeTimer.Stop();
                return;
            }

            if (expanding)
            {
                if (targetPanel.Height < 82)
                {
                    targetPanel.Height = Math.Min(targetPanel.Height + AnimationSpeed, 82);
                }
                else
                {
                    resizeTimer.Stop();
                    ExpandedContainer = targetPanel; // Ensure assignment after expansion
                }
            }
            else
            {
                if (targetPanel.Height > _MenuButtonSize.Height)
                {
                    targetPanel.Height = Math.Max(targetPanel.Height - AnimationSpeed, _MenuButtonSize.Height);
                }
                else
                {
                    resizeTimer.Stop();
                    ExpandedContainer = null; // Ensure reset after collapsing
                }
            }
        }


        public static void GenerateHotelReservationPdf(string filePath, string recipient, string sender, string date, string message, string serialNumber)
        {
            try
            {
                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Hotel Reservation Ticket";

                // Create an empty page
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Set up fonts using built-in PdfSharp-supported fonts
                XFont titleFont = new XFont("Microsoft Sans Serif", 18,XFontStyleEx.Regular);
                XFont textFont = new XFont("Microsoft Sans Serif", 12);

                // Draw title
                gfx.DrawString("HOTEL RESERVATION", titleFont, XBrushes.Black, new XPoint(180, 40));
                gfx.DrawString("HARBORVIEW INN & SUITES", new XFont("Microsoft Sans Serif", 14, XFontStyleEx.Bold), XBrushes.Black, new XPoint(150, 70));

                // Draw reservation details
                double yPoint = 120;
                gfx.DrawString($"Serial No: {serialNumber}", textFont, XBrushes.Black, new XPoint(400, yPoint));
                yPoint += 30;

                gfx.DrawString($"To: {recipient}", textFont, XBrushes.Black, new XPoint(50, yPoint));
                yPoint += 20;
                gfx.DrawString($"From: {sender}", textFont, XBrushes.Black, new XPoint(50, yPoint));
                yPoint += 20;
                gfx.DrawString($"Date: {date}", textFont, XBrushes.Black, new XPoint(50, yPoint));
                yPoint += 30;

                gfx.DrawString("Message:", new XFont("Microsoft Sans Serif", 12, XFontStyleEx.Bold), XBrushes.Black, new XPoint(50, yPoint));
                yPoint += 20;
                gfx.DrawString(message, textFont, XBrushes.Black, new XPoint(50, yPoint));
                yPoint += 40;

                // Draw baggage image from resources
                XImage baggageImage = LoadImageFromResources();
                if (baggageImage != null)
                {
                    gfx.DrawImage(baggageImage, 400, 160, 100, 100);
                }

                // Draw barcode (simulated as text)
                gfx.DrawString("🔲🔲🔲🔲 [Barcode Here] 🔲🔲🔲🔲", textFont, XBrushes.Black, new XPoint(180, 300));

                // Draw footer
                gfx.DrawString("A Special Gift for You", new XFont("Microsoft Sans Serif", 14, XFontStyleEx.Italic), XBrushes.Black, new XPoint(200, 350));

                // Save the document
                document.Save(filePath);

                // Open the created PDF (optional)
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

                Console.WriteLine("PDF created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generating PDF: " + ex.Message);
            }
        }

        // Load image from embedded resources
        public static XImage LoadImageFromResources()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Properties.Resources.BaggageImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return XImage.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading image: " + ex.Message);
                return null;
            }
        }

        // Generate a random serial number
        public static string GenerateRandomSerial()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] serialArray = new char[10];

            for (int i = 0; i < serialArray.Length; i++)
            {
                serialArray[i] = chars[random.Next(chars.Length)];
            }

            return "HTL-" + new string(serialArray);
        }



        public static bool IsValidEmail(string email)
        {
            // Regex pattern to match xxxxxxx@xxxx.xxx format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        static public void EtendPanel(Panel Countiner , Size size)
        {
            Countiner.Visible = true;
            System.Windows.Forms.Timer headertimer = new System.Windows.Forms.Timer();
            headertimer.Interval = 10; // Set delay to 100ms

            headertimer.Tick += (s, e) =>
            {
                if (Countiner.Size.Height < size.Height)
                {
                    Countiner.Size = new Size(Countiner.Size.Width, Countiner.Size.Height + 3);
                }
                else
                {
                    headertimer.Stop(); // Stop when target size is reached
                }
            };
            headertimer.Start();
        }
        static public void Reset(Panel Countiner, Size size)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10; // Set delay to 100ms

            timer.Tick += (s, e) =>
            {
                if (Countiner.Size.Height > size.Height)
                {
                    Countiner.Size = new Size(Countiner.Size.Width, Countiner.Size.Height - 3);
                }
                else
                {

                    timer.Stop(); // Stop when target size is reached
                    Countiner.Visible = false;
                }
            };

            timer.Start();

        }



    }
}
