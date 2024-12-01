using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sodium20i : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium20i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 20.01433d;

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
    