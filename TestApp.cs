public class TestApp
{
	public static void Main()
	{
		System.Random rnd = new System.Random();
		int n = rnd.Next(0, 4);

		System.String m;
		if (n == 1) {
			m = "ëÂãg";
		} else if (n == 2) {
			m = "è¨ãg";
		} else if (n == 3) {
			m = "ãg";
		} else {
			m = "ã•";
		}

		System.Windows.Forms.Form f = new System.Windows.Forms.Form();
		f.Width = 400;
		f.Height = 300;
		f.Font = new System.Drawing.Font("Arial", 20);
		f.Text = "Ç®Ç›Ç≠Ç∂É\ÉtÉg";

		System.Windows.Forms.Label a = new System.Windows.Forms.Label();
		a.Width = 400;
		a.Height = 100;
		a.Text = "ç°ì˙ÇÃâ^ê®ÇÕ " + m;
		f.Controls.Add(a);

		System.Windows.Forms.Application.Run(f);
	}
}