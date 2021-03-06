﻿using System;

namespace Exceptions {
    class Program {
        static void Main(string[] args) {
            try { 
            var a = 1;
            var b = 1;

            try {

                string x = "ABC";
                x = null;
                var len = x.Length;
            } catch (NullReferenceException ex){
                
                var bce = new BootcampException("Boot camp exception", ex);
                throw bce;

            } catch (Exception ex) {
                
                Console.WriteLine(ex.Message);
            }

                try { //Try example for an exception

                    var c = a / (b - b);

                } catch (DivideByZeroException ex) {

                    Console.WriteLine(ex.Message);

                }
                
                } catch (Exception ex) {
                // do something
            }

            //var d = 1 / 0;
        }
    }
}
