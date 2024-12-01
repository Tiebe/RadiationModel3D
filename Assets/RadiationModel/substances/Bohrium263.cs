using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium263";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 263.12292d;

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
    