using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium212";
        public override double halfLife { get; } = 0.0051d;
        public override double atomicWeight { get; } = 212.02319d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium208()), new(1.0d, new AlphaParticle(9437002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    