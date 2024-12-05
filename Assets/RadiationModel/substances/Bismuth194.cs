using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth194 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth194";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 193.9828d;

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
    