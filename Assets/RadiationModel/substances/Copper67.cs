using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper67 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper67";
        public override double halfLife { get; } = 222588.0d;
        public override double atomicWeight { get; } = 66.92773d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc67() }, { 1.0d, new BetaParticle(-1, 280400.0) }, { 0.07d, new GammaParticle(91266.0, 0.01358) }, { 0.161d, new GammaParticle(93311.0, 0.01329) }, { 0.48700000000000004d, new GammaParticle(184577.0, 0.00672) }, { 0.00115d, new GammaParticle(208951.0, 0.00593) }, { 0.00797d, new GammaParticle(300219.0, 0.00413) }, { 0.0022d, new GammaParticle(393529.0, 0.00315) }, { 0.0021252796784560803d, new GammaParticle(1035.0, 1.19791) }, { 0.01969194329792884d, new GammaParticle(8616.0, 0.1439) }, { 0.03829627245804909d, new GammaParticle(8639.0, 0.14352) }, { 0.008216930172622074d, new GammaParticle(9610.0, 0.12902) }, { 0.008216930172622074d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    