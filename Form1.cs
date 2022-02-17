using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
        /* Függvények */
        #region Koch_fraktál 
        void Koch_fraktál(int év, double méret)
        {
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Koch_fraktál(év-1, méret/3);
				Balra(60);
				Koch_fraktál(év - 1, méret / 3);
				Jobbra(120);
				Koch_fraktál(év - 1, méret / 3);
				Balra(60);
				Koch_fraktál(év - 1, méret / 3);
			}
        }
		#endregion

		#region Hópehely
		void Hópehely(int év,double méret)
        {
            for (int i = 0; i < 6; i++)
            {
				Koch_fraktál(év, méret);
				Jobbra(60);
            }
        }
		#endregion

		#region Cikcak
		void Cikcak(int év, double méret)
        {
            if (év==1)
            {
				Előre(méret);
            }
            else if (év>1)
            {
				
				Balra(30);
				Cikcak(év - 1, méret / 3);
				Jobbra(60);
				Cikcak(év - 1, méret / 3);
				Balra(60);
				Cikcak(év - 1, méret / 3);
				Jobbra(30);

			}
		}
		#endregion

		#region ninja_fegyver
		void ninja_fegyver(int év, double méret)
        {
            for (int i = 0; i < 3; i++)
            {
				Cikcak(év, méret);
				Jobbra(120);

			}
        }
		#endregion

		#region C_görbe
		void C_görbe(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Jobbra(90);
				C_görbe(év - 1, méret/3);
				Balra(90);
				C_görbe(év - 1, méret/3);
				C_görbe(év - 1, méret/3);
				Balra(90);
				C_görbe(év - 1, méret/3);
				Jobbra(90);
			}
		}
		#endregion

		#region Nyílhegy_balra
		void Nyílhegy_balra(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Balra(60);
				Nyílhegy_jobbra(év - 1, méret/3);
				Jobbra(60);
				Nyílhegy_balra(év - 1, méret/3);
				Jobbra(60);
				Nyílhegy_jobbra(év - 1, méret / 3);
				Balra(60);
			}
		}
		#endregion

		#region Nyílhegy_jobbra
		void Nyílhegy_jobbra(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Balra(60);
				Nyílhegy_balra(év - 1, méret / 3);
				Jobbra(60);
				Nyílhegy_jobbra(év - 1, méret / 3);
				Jobbra(60);
				Nyílhegy_balra(év - 1, méret / 3);
				Balra(60);
			}
		}
		#endregion

		#region Életjel
		void Életjel(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{

				Életjel(év - 1, méret / 3);
				Jobbra(60);
				Életjel(év - 1, méret / 3);
				Balra(120);
				Életjel(év - 1, méret / 3);
				Életjel(év - 1, méret / 3);
				Jobbra(120);
				Életjel(év - 1, méret / 3);
				Balra(60);


			}
		}
		#endregion

		#region szigetj
		void szigetj(int db, int év, double méret)
		{
            for (int i = 0; i < db; i++)
            {
				Életjel(év, méret);
				Jobbra(72);
            }
		}
        #endregion

        #region fra
        void fra(int év, double méret)
        {
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				fra(év - 1, méret / 2);
				Balra(72);
				fra(év - 1, méret / 2);
				Balra(72);
				fra(év - 1, méret / 2);
				Jobbra(72);
				fra(év - 1, méret / 2);
				Jobbra(144);
				fra(év - 1, méret / 2);
				Balra(72);
				fra(év - 1, méret / 2);
			}
		}
		#endregion

		#region fra5
		void fra5(int db, int év,double méret)
        {
            for (int i = 0; i < db; i++)
            {
				fra(év, méret);
				Balra(72);
            }
        }
		#endregion

		void kocka(int év, double méret)
        {
            if (év==1)
            {
				Előre(méret);
            }
			else if (év > 1)
            {
				kocka(év - 1, méret / 4);
				Balra(90);
				kocka(év - 1, méret / 4);
				Jobbra(90);
				kocka(év - 1, méret / 4);
				Jobbra(90);
				kocka(év - 1, méret / 4);
				kocka(év - 1, méret / 4);
				Balra(90);
				kocka(év - 1, méret / 4);
				Balra(90);
				kocka(év - 1, méret / 4);
				Jobbra(90);
				kocka(év - 1, méret / 4);


			}

		}

		void Hegycsúcs(int év, double méret)
        {
            if (év==1)
            {
				Előre(méret);
            }
			else if (év > 1)
            {
			Hegycsúcs(év - 1, méret / 4);
			Balra(60);
			Hegycsúcs(év - 1, méret / 4);
			Jobbra(120);
			Hegycsúcs(év - 1, méret / 4);
			Hegycsúcs(év - 1, méret / 4);
			Balra(120);
			Hegycsúcs(év - 1, méret / 4);
			Jobbra(60);
			Hegycsúcs(év - 1, méret / 4);

            }
			


		}

		void Nehéz_négyzet_jobbra(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
            {
				Nehéz_négyzet_jobbra(év - 1, méret / 3);
				Balra(90);
				Nehéz_négyzet_balra(év - 1, méret / 3);
				Jobbra(90);
				Nehéz_négyzet_jobbra(év - 1, méret / 3);
				Jobbra(90);
				Nehéz_négyzet_balra(év - 1, méret / 3);
				Balra(90);
				Nehéz_négyzet_jobbra(év - 1, méret / 3);
			}
		}
		void Nehéz_négyzet_balra(int év, double méret)
		{
			if (év == 1)
			{
				Előre(méret);
			}
			else if (év > 1)
			{
				Nehéz_négyzet_balra(év - 1, méret / 3);
				Jobbra(90);
				Nehéz_négyzet_jobbra (év -1, méret / 3);
				Balra(90);
				Nehéz_négyzet_balra(év - 1, méret / 3);
				Balra(90);
				Nehéz_négyzet_jobbra (év -1, méret / 3);
				Jobbra(90);
				Nehéz_négyzet_balra(év - 1, méret / 3);





			}
		}
		/* Függvények vége */
		void FELADAT()

		{ 
			Teleport(közép.X-350, közép.Y+150, kelet);
			
			using (new Frissítés(false))
			{
				Nehéz_négyzet_jobbra(6, 700);
			}
		}
	}
}
