using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum181n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum181n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 180.94866d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum181()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    