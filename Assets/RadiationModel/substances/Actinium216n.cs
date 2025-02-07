using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium216n : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium216n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 216.0092d;

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
    