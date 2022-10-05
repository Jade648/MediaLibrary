
using System;
using System.Collections.Generic;
using System.IO;
using NLog.Web;
                    // create instance of Movie class
                    public class Movie {

                    private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();

                     StreamReader sr = new StreamReader("//Movies.Scrubbed.csv");
                   
                    Movie movie = new Movie();

                   string line = sr.Readline();


                    }
                    sr.Close();
 
                   logger.Info("Entered a movie into Movie file");
            
                    
                
                
