using System;
using System.Collections.Generic;
using System.Text;
using HexQFormat.Models;

namespace HexQFormat.ViewModels
{

    public class ResultViewModel
    {

        private double _Result;

        public double Result
        {
            get
            {
                return _Result;
            }
            set
            {
                _Result = value;
            }
        }

        public String getFormattedResult(ResultFormat format)
        {
            return "";
        }


        public ResultFormat Format { get; set; }

        public ResultViewModel()
        {
            // default result format
            Format = ResultFormat.DEC;
        }

        


    }
}
