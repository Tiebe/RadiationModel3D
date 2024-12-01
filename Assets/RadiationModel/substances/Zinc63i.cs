using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc63i : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc63i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 62.93911d;

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
    