using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium193m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 192.96771d;

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
    