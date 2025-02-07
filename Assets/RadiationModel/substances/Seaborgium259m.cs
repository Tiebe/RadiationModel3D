using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Seaborgium259m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium259m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 259.11445d;

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
    