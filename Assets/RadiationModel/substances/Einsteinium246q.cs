using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium246q : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium246q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 246.07322d;

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
    