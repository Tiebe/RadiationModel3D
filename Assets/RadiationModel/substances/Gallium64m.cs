using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium64m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium64m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 63.93689d;

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
    