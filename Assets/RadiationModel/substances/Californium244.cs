using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium244";
        public override double halfLife { get; } = 1164.0d;
        public override double atomicWeight { get; } = 244.066d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium240()), new(1.0d, new AlphaParticle(8350902.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    