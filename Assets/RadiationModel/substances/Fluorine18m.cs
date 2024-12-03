using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine18m : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine18m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 18.00214d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fluorine18()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    