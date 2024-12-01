using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium251m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 251.08d;

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
    