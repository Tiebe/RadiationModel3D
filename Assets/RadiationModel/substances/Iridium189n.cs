using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium189n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 188.96123d;

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
    