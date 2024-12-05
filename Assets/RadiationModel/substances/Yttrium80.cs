using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium80";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 79.93435d;

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
    