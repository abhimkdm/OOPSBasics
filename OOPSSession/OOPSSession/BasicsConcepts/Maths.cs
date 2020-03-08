using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts
{
    public class Maths
    {
        public delegate void ClickEventHandler(object sender, EventArgs e);
        public event ClickEventHandler Check;

        public void Even_Click(object sender, EventArgs e) {
            Console.WriteLine("Even" + sender);
        }

        public void Odd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Odd" + sender);
        }

        public void CheckNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    this.Even_Click(i, EventArgs.Empty); //Even
                }
                else if (i % 2 != 0)
                {
                    this.Odd_Click(i, EventArgs.Empty); //Odd
                }
            }
        }
    }
}
