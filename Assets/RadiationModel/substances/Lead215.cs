using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead215 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead215";
        public override double halfLife { get; } = 147.0d;
        public override double atomicWeight { get; } = 215.00466d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth215() }, { 1.0d, new BetaParticle(-1, 1355500.0) }, { 0.087d, new GammaParticle(183500.0, 0.00676) }, { 0.01218d, new GammaParticle(671000.0, 0.00185) }, { 0.01044d, new GammaParticle(760000.0, 0.00163) }, { 0.018269999999999998d, new GammaParticle(839000.0, 0.00148) }, { 0.02088d, new GammaParticle(985000.0, 0.00126) }, { 0.01218d, new GammaParticle(1016000.0, 0.00122) }, { 0.014790000000000001d, new GammaParticle(1200000.0, 0.00103) }, { 0.04180008960000001d, new GammaParticle(12904.0, 0.09608) }, { 0.029414101286223952d, new GammaParticle(74815.0, 0.01657) }, { 0.049212148713776056d, new GammaParticle(77108.0, 0.01608) }, { 0.016857082695252677d, new GammaParticle(87388.0, 0.01419) }, { 0.02201535d, new GammaParticle(88458.0, 0.01402) }, { 0.00515826730474732d, new GammaParticle(89784.0, 0.01381) } } },

        };
    }
}
    