using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium162m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 161.92958d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    