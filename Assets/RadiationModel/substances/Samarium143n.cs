using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium143n : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium143n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 142.91763d;

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
    