using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium172";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 171.97061d;

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
    