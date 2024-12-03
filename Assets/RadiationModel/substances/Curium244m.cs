using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium244m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium244m";
        public override double halfLife { get; } = 0.034d;
        public override double atomicWeight { get; } = 244.06387d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium244()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    