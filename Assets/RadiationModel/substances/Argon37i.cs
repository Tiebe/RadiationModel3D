using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon37i : RadioactiveSubstance
    {
        public override string name { get; } = "Argon37i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 36.97214d;

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
    