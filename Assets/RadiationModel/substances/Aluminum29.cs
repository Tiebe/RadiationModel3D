using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum29 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum29";
        public override double halfLife { get; } = 393.6d;
        public override double atomicWeight { get; } = 28.98045d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon29() }, { 1.0d, new BetaParticle(-1, 1843640.75) }, { 0.000292032d, new GammaParticle(397850.0, 0.00312) }, { 0.00310284d, new GammaParticle(754840.0, 0.00164) }, { 7.3008e-05d, new GammaParticle(1039100.0, 0.00119) }, { 0.010312380000000001d, new GammaParticle(1152570.0, 0.00108) }, { 0.9126000000000001d, new GammaParticle(1273361.0, 0.00097) }, { 0.000264654d, new GammaParticle(1793830.0, 0.00069) }, { 0.0351351d, new GammaParticle(2028090.0, 0.00061) }, { 0.05229198d, new GammaParticle(2425730.0, 0.00051) } } },

        };
    }
}
    