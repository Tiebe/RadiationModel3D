using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium140m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 139.90771d;

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
    