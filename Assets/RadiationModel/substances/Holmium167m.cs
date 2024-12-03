using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium167m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 166.93342d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium167()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    