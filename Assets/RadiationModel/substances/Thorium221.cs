using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium221";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 221.01819d;

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
    