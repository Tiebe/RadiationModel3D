using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Seaborgium262p : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium262p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 262.11726d;

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
    