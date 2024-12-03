using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium94m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 93.91418d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium94()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    