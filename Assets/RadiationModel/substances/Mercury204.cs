using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury204 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury204";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 203.97349d;

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
    