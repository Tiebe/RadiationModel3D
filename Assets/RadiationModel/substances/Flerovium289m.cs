using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Flerovium289m : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium289m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 289.19133d;

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
    