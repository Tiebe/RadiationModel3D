using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium36 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium36";
        public override double halfLife { get; } = 0.1012d;
        public override double atomicWeight { get; } = 35.99308d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon36() }, { 1.0d, new BetaParticle(1, 11890771.0) }, { 0.13d, new GammaParticle(1112400.0, 0.00111) }, { 0.3d, new GammaParticle(1618600.0, 0.00077) }, { 2.032d, new GammaParticle(511000.0, 0.00243) }, { 1.504198257772e-06d, new GammaParticle(311.0, 3.98663) }, { 2.0288947149065154e-05d, new GammaParticle(3311.0, 0.37446) }, { 4.013639396452058e-05d, new GammaParticle(3314.0, 0.37412) }, { 7.402104286414254e-06d, new GammaParticle(3591.0, 0.34526) }, { 7.402104286414254e-06d, new GammaParticle(3591.0, 0.34526) } } },
            { 0.512d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon35() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    