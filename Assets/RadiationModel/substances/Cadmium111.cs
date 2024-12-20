using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium111";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 110.90418d;

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
    