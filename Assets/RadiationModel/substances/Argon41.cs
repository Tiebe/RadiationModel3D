using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon41 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon41";
        public override double halfLife { get; } = 6576.6d;
        public override double atomicWeight { get; } = 40.9645d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium41() }, { 1.0d, new BetaParticle(-1, 1246024.5) }, { 0.9915999999999999d, new GammaParticle(1293640.0, 0.00096) }, { 0.0005156319999999999d, new GammaParticle(1677000.0, 0.00074) }, { 1.9842448637329175e-07d, new GammaParticle(311.0, 3.98663) }, { 2.6981522252461593e-06d, new GammaParticle(3311.0, 0.37446) }, { 5.337590950041858e-06d, new GammaParticle(3314.0, 0.37412) }, { 9.843785389727823e-07d, new GammaParticle(3591.0, 0.34526) }, { 9.843785389727823e-07d, new GammaParticle(3591.0, 0.34526) } } },

        };
    }
}
    