using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine211 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine211";
        public override double halfLife { get; } = 25970.4d;
        public override double atomicWeight { get; } = 210.9875d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.5820000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium211()), new(0.00261d, new GammaParticle(687000.0, 0.0018)), new(0.185979178802508d, new GammaParticle(13292.0, 0.09328)), new(0.1265285538279574d, new GammaParticle(76862.0, 0.01613)), new(0.2107053352672064d, new GammaParticle(79290.0, 0.01564)), new(0.07254001275731213d, new GammaParticle(89837.0, 0.0138)), new(0.09509995672483619d, new GammaParticle(90941.0, 0.01363)), new(0.022559943967524074d, new GammaParticle(92315.0, 0.01343)) } },
            { 0.418d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth207()), new(1.0d, new AlphaParticle(7004402.09)), new(5.016e-07d, new GammaParticle(149697.0, 0.00828)), new(3.553e-07d, new GammaParticle(222690.0, 0.00557)), new(3.7000000000000005e-05d, new GammaParticle(669780.0, 0.00185)), new(1e-05d, new GammaParticle(742720.0, 0.00167)), new(1.421e-06d, new GammaParticle(892400.0, 0.00139)), new(1.2562498436301002e-06d, new GammaParticle(12904.0, 0.09608)), new(8.942585235045495e-07d, new GammaParticle(74815.0, 0.01657)), new(1.4961661761829505e-06d, new GammaParticle(77108.0, 0.01608)), new(5.124953414337672e-07d, new GammaParticle(87388.0, 0.01419)), new(6.693189159124999e-07d, new GammaParticle(88458.0, 0.01402)), new(1.5682357447873274e-07d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    