using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium155m";
        public override double halfLife { get; } = 0.00088d;
        public override double atomicWeight { get; } = 154.92926d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium155()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    