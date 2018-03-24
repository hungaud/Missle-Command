using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissileCommand {
   public partial class MissileCommand {

      private void pauseToolStripMenuItem_Click(object sender, EventArgs e) {
         playButton_Click(sender, e);
      }

      private void constantCheckbox_Click(object sender, EventArgs e) {
         if (increaseCheckbox.Checked) {
            increaseCheckbox.Checked = false;
         }
         constantCheckbox.Checked = true;
      }

      private void increaseLabel_Click(object sender, EventArgs e) {
         if (constantCheckbox.Checked) {
            constantCheckbox.Checked = false;
         }
         increaseCheckbox.Checked = true;
      }

      private void startToolStripMenuItem_Click(object sender, EventArgs e) {
         playButton_Click(sender, e);
      }

      private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
         Application.Exit();
      }

      private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
         rulesToolStripMenuItem_Click(sender, e);
      }

      private void rulesToolStripMenuItem_Click(object sender, EventArgs e) {
         string str = " Missile Command Game by Atari \n ";
         str += " destroy the missile before they hit the city \n";
         MessageBox.Show(str);
      }

      private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) {
         MessageBox.Show("Missile Command by Brian and Hung");
      }
   }

}
