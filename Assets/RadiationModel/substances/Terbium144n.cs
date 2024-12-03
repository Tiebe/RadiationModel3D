using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium144n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium144n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 143.93356d;

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
    