using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium166";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 165.98571d;

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
    