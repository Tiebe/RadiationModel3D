using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Berkelium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium251m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 251.0808d;

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
    