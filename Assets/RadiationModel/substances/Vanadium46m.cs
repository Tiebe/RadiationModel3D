using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium46m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium46m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 45.96106d;

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
    