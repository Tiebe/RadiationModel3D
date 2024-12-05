using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin125n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin125n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 124.90982d;

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
    