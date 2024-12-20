using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium152";
        public override double halfLife { get; } = 3.408148005255936e+21d;
        public override double atomicWeight { get; } = 151.9198d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium148()), new(1.0d, new AlphaParticle(3225802.0900000003)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    