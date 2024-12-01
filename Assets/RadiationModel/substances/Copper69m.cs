using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper69m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper69m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 68.93237d;

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
    