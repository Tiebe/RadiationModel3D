using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium256p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium256p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 256.09415d;

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
    