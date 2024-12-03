using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium167";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 166.95301d;

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
    