using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon34i : RadioactiveSubstance
    {
        public override string name { get; } = "Argon34i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 33.98879d;

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
    