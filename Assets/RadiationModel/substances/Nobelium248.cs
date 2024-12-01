using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium248";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 248.08662d;

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
    