using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium198p : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium198p";
        public override double halfLife { get; } = 0.0321d;
        public override double atomicWeight { get; } = 197.97124d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium198()), new(0.0008100000000000001d, new GammaParticle(23100.0, 0.05367)), new(0.20600000000000002d, new GammaParticle(198800.0, 0.00624)), new(0.062d, new GammaParticle(259500.0, 0.00478)), new(0.0276d, new GammaParticle(260900.0, 0.00475)), new(0.61d, new GammaParticle(282800.0, 0.00438)), new(0.600302783736d, new GammaParticle(12148.0, 0.10206)), new(0.211861016089542d, new GammaParticle(70832.0, 0.0175)), new(0.3576316949519615d, new GammaParticle(72874.0, 0.01701)), new(0.12162643096260331d, new GammaParticle(82629.0, 0.015)), new(0.15774948095849647d, new GammaParticle(83631.0, 0.01483)), new(0.03612304999589318d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    