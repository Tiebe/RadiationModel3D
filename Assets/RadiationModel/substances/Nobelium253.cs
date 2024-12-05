using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 253.09056d;

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
    