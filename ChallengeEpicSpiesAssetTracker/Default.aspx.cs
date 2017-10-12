using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetName = new string[0];
                int[] rigged = new int[0];
                int[] subterfuge = new int[0];

                ViewState.Add("AssetName", assetName);
                ViewState.Add("ElectionsRigged", rigged);
                ViewState.Add("SubterfugePerformed", subterfuge);
            }

        }

        protected void addAssetBtn_Click(object sender, EventArgs e)
        {
            string[] assetName = (string[])ViewState["AssetName"];
            int assetLength = assetName.Length + 1;
            Array.Resize(ref assetName, assetLength);
            int assetIndex = assetName.GetUpperBound(0);

            int[] rigged = (int[])ViewState["ElectionsRigged"];
            int riggedLength = rigged.Length + 1;
            Array.Resize(ref rigged, riggedLength);
            int riggedIndex = rigged.GetUpperBound(0);

            int[] subterfuge = (int[])ViewState["SubterfugePerformed"];
            int subterfugeLength = subterfuge.Length + 1;
            Array.Resize(ref subterfuge, subterfugeLength);
            int subterfugeIndex = subterfuge.GetUpperBound(0);

            assetName[assetIndex] = nameTextBox.Text;
            rigged[riggedIndex] = int.Parse(riggedTextBox.Text);
            subterfuge[subterfugeIndex] = int.Parse(subterfugeTextBox.Text);

            ViewState["AssetName"] = assetName;
            ViewState["ElectionsRigged"] = rigged;
            ViewState["SubterfugePerformed"] = subterfuge;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}" +
                "<br /> Average Acts of Subterfuge per Asset: {1:N2}" +
                "<br />(Last Asset you Added: {2})", rigged.Sum(), subterfuge.Average(),assetName.Last());

            nameTextBox.Text = "";
            riggedTextBox.Text = "";
            subterfugeTextBox.Text = "";




        }
    }
}