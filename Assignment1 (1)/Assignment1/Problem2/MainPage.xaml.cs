using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


    namespace Problem2
    {

        public class MyTestClass
        {
            public string getUpperCase(string a)
            {
                return a.ToUpper();
            }

            public int getLength(string a)
            {
                return a.Length;
            }
        }


        /// <summary>
        /// An empty page that can be used on its own or navigated to within a Frame.
        /// </summary>
        public sealed partial class MainPage : Page
        {
            public MainPage()
            {
                this.InitializeComponent();
            }

            ///We need this line to access a method that needs to be
            ///wrapped in a delegate object
            public MyTestClass c = new MyTestClass();


        ////////////////////////////////////////////////////////////////
        //A custom delegate class MyFunc1 has been used. 
        //Provide declaration for that delegate class.
        //(2 mark)
        ////////////////////////////////////////////////////////////////
        //YOUR CODE GOES HERE 
        public delegate string MyFunc1(string args);

        ////////////////////////////////////////////////////////////////
        //A custom delegate class MyFunc2 has been used. 
        //Provide declaration for that delegate class.
        //(2 mark)
        ////////////////////////////////////////////////////////////////
        //YOUR CODE GOES HERE                
        public delegate int MyFunc2(string args);

        //handler method for click on left button
        private void leftButton_onClick(object sender, RoutedEventArgs e)
            {
                MyFunc1 aDel;

                aDel = c.getUpperCase;

                //The argument to be passed to the wrapped method is
                //saved in variable theWord.
                string theWord = textbox1.Text;


                string sUpper;
            //////////////////////////////////////////////////////////////
            //Call the method wrapped in aDel (USE Invoke method).
            //Save the returned value from the call, in variable sUpper.
            //(2 mark)
            //////////////////////////////////////////////////////////////
            //YOUR CODE GOES HERE                     
            sUpper = aDel.Invoke(theWord);


                //Write the value in sUpper to textBlock
                textblock1.Text = sUpper;
            }

            //handler method for click on right button
            private void rightButton_onClick(object sender, RoutedEventArgs e)
            {

                MyFunc2 bDel;

                bDel = c.getLength;

                //The argument to be passed to the wrapped method is
                //saved in variable theWord.
                string theWord = textbox1.Text;

                int sLength;
            //////////////////////////////////////////////////////////////
            //Call the method wrapped in bDel (DO NOT USE Invoke method).
            //Save the returned value from the call, in variable sLength. 
            //(2 mark)
            ///////////////////////////////////////////////////////////////
            //YOUR CODE GOES HERE                       
            sLength = bDel.Invoke(theWord);



                ///Write the value in sLength to textBlock
                textblock1.Text = "" + sLength;
            }
        }
    }


