using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium189n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium189n";
        public override double halfLife { get; } = 0.00022d;
        public override double atomicWeight { get; } = 188.96113d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium189()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    