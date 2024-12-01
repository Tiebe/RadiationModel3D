using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony104 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony104";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 103.93634d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium104()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium103()), new(1.0d, new ProtonParticle()) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin103()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    