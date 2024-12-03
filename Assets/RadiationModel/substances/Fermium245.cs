using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium245";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 245.07535d;

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
    