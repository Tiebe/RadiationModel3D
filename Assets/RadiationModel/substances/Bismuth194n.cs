using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth194n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth194n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 193.98297d;

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
    