using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium111";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 110.9259d;

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
    