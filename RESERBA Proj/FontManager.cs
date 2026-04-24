using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public static class FontManager
    {
        private static PrivateFontCollection customFonts = new PrivateFontCollection();

        public static FontFamily? HeadlineFamily { get; private set; } // Rounded
        public static FontFamily? BodyFamily { get; private set; }     // Aribau

        public static void LoadFonts()
        {
            string fontsFolder = Path.Combine(Application.StartupPath, "Fonts");

            try
            {
                string[] fontFiles = Directory.GetFiles(fontsFolder, "*.*")
                    .Where(f => f.EndsWith(".ttf") || f.EndsWith(".otf"))
                    .ToArray();

                foreach (string file in fontFiles)
                    customFonts.AddFontFile(file);

                foreach (FontFamily family in customFonts.Families)
                {
                    string name = family.Name.ToLower();
                    if (name.Contains("rounded"))
                        HeadlineFamily = family;
                    else if (name.Contains("aribau"))
                        BodyFamily = family;
                }

                // Fallbacks if fonts not found
                if (HeadlineFamily == null)
                    HeadlineFamily = new FontFamily("Arial Rounded MT Bold");
                if (BodyFamily == null)
                    BodyFamily = new FontFamily("Segoe UI");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load fonts: " + ex.Message);
                HeadlineFamily = new FontFamily("Arial");
                BodyFamily = new FontFamily("Segoe UI");
            }
        }

        // Rounded font — for headlines
        public static Font GetHeadline(float size, FontStyle style = FontStyle.Regular)
        {
            if (HeadlineFamily == null) return new Font("Arial", size, style);
            return new Font(HeadlineFamily, size, style);
        }

        // Aribau font — for body/small text
        public static Font GetBody(float size, FontStyle style = FontStyle.Regular)
        {
            if (BodyFamily == null) return new Font("Segoe UI", size, style);
            return new Font(BodyFamily, size, style);
        }

        // Backward compatibility
        public static Font GetPlayfair(float size, FontStyle style = FontStyle.Regular)
            => GetHeadline(size, style);

        public static void ApplyTo(Control uiControl, FontStyle style = FontStyle.Regular)
        {
            uiControl.Font = GetHeadline(uiControl.Font.Size, style);
        }

        public static void ApplyFontToAll(Control parentControl)
        {
            foreach (Control c in parentControl.Controls)
            {
                if (c is Button || c is Label || c is LinkLabel || c is CheckBox)
                {
                    if (c.Font.Size >= 14f)
                        c.Font = GetHeadline(c.Font.Size, c.Font.Style);
                    else
                        c.Font = GetBody(c.Font.Size, c.Font.Style);
                }
                else if (c is TextBox)
                {
                    c.Font = GetBody(c.Font.Size, c.Font.Style);
                }

                if (c.HasChildren)
                    ApplyFontToAll(c);
            }
        }
    }
}