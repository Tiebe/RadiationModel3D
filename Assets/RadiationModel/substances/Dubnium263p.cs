using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dubnium263p : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium263p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 263.11527d;

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
    