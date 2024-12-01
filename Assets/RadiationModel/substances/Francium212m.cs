using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium212m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium212m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 211.99789d;

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
    