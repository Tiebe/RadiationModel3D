using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium220n : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium220n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 220.02208d;

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
    