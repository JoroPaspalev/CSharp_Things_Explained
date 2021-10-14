using System;
using System.Threading;
using System.Windows.Forms;

namespace Threads_and_MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{  //1. Когато кликна върху първия бутон ще вляза тук.
        //   //2. първо Desable-вам двата бутона за да немогат да се натискат докато не се свърши работата от Main thread-а, защото така или иначе app-а няма да отговаря през тези 5000 милисекунди
        //    button1.Enabled = false;
        //    button2.Enabled = false;

        //    //3. Тука фиктивно задавам забавяне от 5 sec т.е. имитирам четене на заявка от базата
        //    this.WaitMethod();

        //    //4. Тука вече треда е свободен и се връща на този ред да продължи нататък
        //    button1.Enabled = true;
        //    button2.Enabled = true;
        //}


        // 5. Сега закоментирай горния метод private void button1_Click_1(){целия метод с бодито му}
        // 6. Сега разкомнтирай този за да направим Async операциите
        private void button1_Click_1(object sender, EventArgs e)
        {
            // 7. Тук правим нов Thread, който е различен от Main Thread-а а в скобите му подаваме метода който ще time consuming
            // т.е. казваме Направи ми нов Thread и му дай задача която да свърши
            Thread newThread = new Thread(WaitMethod);
            //Сега трябва да стартираме Thread-а иначе нищо не става!!!!
            newThread.Start();    
            
            // Така вече основния тред продължава по кода надолу без да чака резултата от метода който отнема много време, като новосъздадения Thread2 почва да си обработва възложената му задача
        }

        private void WaitMethod()
        {
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            for (int i = 1; i < 11; i++)
            {
                this.listBox1.Items.Add(i);
            }
        }
    }
}
