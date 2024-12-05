using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper55 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper55";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 54.96603d;

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
    