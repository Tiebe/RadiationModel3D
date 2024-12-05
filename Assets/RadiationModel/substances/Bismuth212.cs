using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth212 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 211.99129d;

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
    