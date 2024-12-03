using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium64";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 63.98248d;

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
    