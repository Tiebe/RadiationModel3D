using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium146m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium146m";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 145.91793d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium146()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    