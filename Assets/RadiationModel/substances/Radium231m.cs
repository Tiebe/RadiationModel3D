using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium231m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium231m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 231.0411d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium231()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    