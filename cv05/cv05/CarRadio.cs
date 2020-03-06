using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class CarRadio
    {

        private Dictionary<int, double> preset;
        private bool radioOn = false;
        private double radioFrekvency = 87.5;

        public CarRadio()
        {
            preset = new Dictionary<int, double> ();
        }

        public bool RadioOn
        {
            get
            {
                return radioOn;
            }
            set
            {
               radioOn = value;
            }
        }

        public double RadioFrekvency
        {
            get
            {
                return radioFrekvency;
            }
            set
            {
                
                if (TestFrekvencyValue(value))
                {
                    radioFrekvency = value;
                }
                else
                {
                    throw new Exception("Frekvency is not middle Europe FM (87,5-108) MHz in change RadioFrekvecy value");
                }
            }
        }

        public void SetPreset(int numberOfPreset, double frekvency)
        {
            if (TestFrekvencyValue(frekvency))
            {
                if (numberOfPreset >= 0)
                {
                    preset.Add(numberOfPreset, frekvency);
                }
                else
                {
                    throw new Exception("numberOfPreset can NOT be negative value");
                }
            }
            else
            {
                throw new Exception("Frekvency is not middle Europe FM (87,5-108) MHz in SetPreset function");
            }
        }

        public void SelectPreset(int numberOfPreset)
        {
            if (preset.ContainsKey(numberOfPreset))
            {
                radioOn = true;
                radioFrekvency = preset[numberOfPreset];
            }
            else
            {
                throw new Exception("Number of Preset is NOT exists");
            }

        }

        private static bool TestFrekvencyValue(double frekvency)
        {    
            if ((frekvency >= 87.5) && (frekvency <= 108))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder("");
            buffer.Append("Radio\t");
            if (RadioOn)
            {
                buffer.Append("ON");
            }
            else
            {
                buffer.Append("OFF");
            }
            buffer.AppendFormat("\tFrekvency: {0} FM\t", RadioFrekvency);
            foreach (KeyValuePair<int, double> item in preset)
            {
                buffer.AppendFormat("[{0}:{1} FM]",item.Key,item.Value);
            }
            return buffer.ToString();
        }

    }
}
