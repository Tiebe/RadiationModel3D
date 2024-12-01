using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium133m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 132.93869d;

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
    