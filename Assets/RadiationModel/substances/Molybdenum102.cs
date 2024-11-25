using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum102 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum102";
        public override double halfLife { get; } = 678.0d;
        public override double atomicWeight { get; } = 101.91029d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium102() }, { 1.0d, new BetaParticle(-1, 506000.0) }, { 0.000247d, new GammaParticle(42850.0, 0.02893) }, { 0.001026d, new GammaParticle(93240.0, 0.0133) }, { 0.002318d, new GammaParticle(136020.0, 0.00912) }, { 0.03762d, new GammaParticle(148190.0, 0.00837) }, { 0.038d, new GammaParticle(211660.0, 0.00586) }, { 0.01444d, new GammaParticle(223830.0, 0.00554) }, { 0.0008359999999999999d, new GammaParticle(266600.0, 0.00465) }, { 0.00266d, new GammaParticle(359900.0, 0.00344) }, { 0.0002796442103156d, new GammaParticle(2586.0, 0.47944) }, { 0.001334212524321392d, new GammaParticle(18250.0, 0.06794) }, { 0.002537008032556364d, new GammaParticle(18367.0, 0.0675) }, { 0.0006742877256668769d, new GammaParticle(20695.0, 0.05991) }, { 0.0007808251863222434d, new GammaParticle(20820.0, 0.05955) }, { 0.00010653746065536657d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    