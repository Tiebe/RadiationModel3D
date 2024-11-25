using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum22 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum22";
        public override double halfLife { get; } = 0.0911d;
        public override double atomicWeight { get; } = 22.01954d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium22() }, { 1.0d, new BetaParticle(1, 11690695.0) }, { 0.38d, new GammaParticle(1246980.0, 0.00099) }, { 0.31d, new GammaParticle(1984800.0, 0.00062) }, { 0.34d, new GammaParticle(2061090.0, 0.0006) }, { 0.017d, new GammaParticle(2143500.0, 0.00058) }, { 1.8506d, new GammaParticle(511000.0, 0.00243) }, { 6.465396000000001e-09d, new GammaParticle(46.0, 26.95309) }, { 2.025469879456596e-07d, new GammaParticle(1254.0, 0.98871) }, { 1.0190138963546134e-07d, new GammaParticle(1254.0, 0.98871) } } },
            { 0.55d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium21() }, { 1.0d, new BetaParticle(1, 475939481.736) }, { 1.0d, new ProtonParticle() }, { 0.318d, new GammaParticle(332000.0, 0.00373) }, { 0.0034999999999999996d, new GammaParticle(1112900.0, 0.00111) }, { 0.0040999999999999995d, new GammaParticle(1385500.0, 0.00089) } } },
            { 0.011000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon20() }, { 1.0d, new BetaParticle(1, 944115069.572) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    