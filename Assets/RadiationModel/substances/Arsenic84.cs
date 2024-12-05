using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Arsenic84 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic84";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 83.9293d;

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
    