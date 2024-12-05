using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium8j : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium8j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 8.03482d;

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
    