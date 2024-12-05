using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium182m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium182m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 181.95408d;

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
    