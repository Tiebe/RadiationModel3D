using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Seaborgium263m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium263m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 263.11836d;

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
    