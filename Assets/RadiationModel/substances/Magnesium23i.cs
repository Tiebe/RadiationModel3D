using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Magnesium23i : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium23i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 23.0025d;

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
    