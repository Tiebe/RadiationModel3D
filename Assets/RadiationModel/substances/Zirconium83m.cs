using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium83m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 82.9293d;

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
    