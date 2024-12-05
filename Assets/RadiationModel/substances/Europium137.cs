using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium137";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 136.93543d;

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
    