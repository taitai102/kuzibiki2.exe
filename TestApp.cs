public class TestApp
{
	public static void Main()
	{
		System.Random rnd = new System.Random();
		int n = rnd.Next(0, 4);

		System.String m;
		if (n == 1) {
			m = "��g";
		} else if (n == 2) {
			m = "���g";
		} else if (n == 3) {
			m = "�g";
		} else {
			m = "��";
		}

		System.Windows.Forms.Form f = new System.Windows.Forms.Form();
		f.Width = 400;
		f.Height = 300;
		f.Font = new System.Drawing.Font("Arial", 20);
		f.Text = "���݂����\�t�g";

		System.Windows.Forms.Label a = new System.Windows.Forms.Label();
		a.Width = 400;
		a.Height = 100;
		a.Text = "�����̉^���� " + m;
		f.Controls.Add(a);

		System.Windows.Forms.Application.Run(f);
	}
}