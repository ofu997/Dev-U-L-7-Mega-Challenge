using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUL7CasinoChallenge
{
	public partial class Casino : System.Web.UI.Page
	{
		Random randomthing = new Random();

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			// displays images in image1
			//string image = images[randomthing.Next(11)];
			//Image1.ImageUrl = "/Images/" + image + ".png";
			int bet = 0;
			if (!int.TryParse(betTextBox.Text, out bet)) return; 
			int winnings=pullLever(bet);
			displayResult(bet, winnings); 
		}

		private void displayResult(int bet, int winnings)
		{
			//throw new NotImplementedException();
			if (winnings > 0)
			{
				resultLabel.Text = String.Format("You bet {0:C} and won {1:C} !", bet, winnings);
			}
			else
			{
				resultLabel.Text = String.Format("Sorry, you lost your {0:C}. Better luck next time.", bet); 
			}
		}

		private void displayImages(string[] reels)
		{
			Image1.ImageUrl = "/Images/" + reels[0] + ".png";
			Image2.ImageUrl = "/Images/" + reels[1] + ".png";
			Image3.ImageUrl = "/Images/" + reels[2] + ".png";
		}

		private int pullLever(int bet)
		{
			string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
			displayImages(reels);

			int multiplier = evaluateSpin(reels );
			return bet*multiplier;
		}

		private int evaluateSpin(string[]reels)
		{
			// throw new NotImplementedException();
			if (isBar(reels)) return 0;
			if (isJackpot(reels)) return 100;
			// if >=1 cherries,return2,3,4
			int multiplier = 0;
			if (isWinner(reels, out multiplier)) return multiplier;
			return 0; 
		}

		private bool isWinner(string[] reels, out int multiplier)
		{
			multiplier = determineMultiplier(reels );
			if (multiplier > 0) return true;
			return false; 

			//throw new NotImplementedException();
			//int cherryCount = determineCherryCount(reels);
			// if (reels[0] == "Cherry") cherryCount++;
		}

		private int determineMultiplier(string[]reels ) {

			int cherryCount = determineCherryCount(reels); 
			if (cherryCount == 1) return 2 ;
			if (cherryCount == 2) return  3 ;
			if (cherryCount == 3) return 4 ;
			return 0;   

		}
		private int determineCherryCount(string[] reels)
		{
			int cherryCount = 0;
			if (reels[0] == "Cherry")cherryCount++;
			if (reels[1] == "Cherry") cherryCount++;
			if (reels[2] == "Cherry") cherryCount++;
			return cherryCount;
		}


			private bool isBar(string[] reels)
		{
			if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
				return true;
			else
				return false; 
		}

		private bool isJackpot(string[] reels)
		{
			//throw new NotImplementedException();
			if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
				return true;
			else
				return false;
		}

		private string spinReel() {
			string[] images = new string[] { "Watermellon", "Strawberry", "Seven", "Plum", "Orange", "Lemon", "HorseShoe", "Diamond", "Clover", "Cherry", "Bell", "Bar" };
			
			return images[randomthing.Next(11)];
		}
	}
}