using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium98m";
        public override double halfLife { get; } = 0.89d;
        public override double atomicWeight { get; } = 97.94301d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver98()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.5432d, new GammaParticle(147200.0, 0.00842)), new(0.5544d, new GammaParticle(198400.0, 0.00625)), new(0.5152d, new GammaParticle(687800.0, 0.0018)), new(0.56d, new GammaParticle(1395500.0, 0.00089)), new(1.276d, new GammaParticle(511000.0, 0.00243)), new(0.0168d, new GammaParticle(3388.0, 0.36595)), new(0.055999999999999994d, new GammaParticle(22983.0, 0.05395)), new(0.105d, new GammaParticle(23173.0, 0.0535)), new(0.028999999999999998d, new GammaParticle(26184.0, 0.04735)), new(0.035d, new GammaParticle(26381.0, 0.047)), new(0.0053d, new GammaParticle(26641.0, 0.04654)) } },
            { 0.44d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver97()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    