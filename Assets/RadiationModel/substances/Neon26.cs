using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon26 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon26";
        public override double halfLife { get; } = 0.197d;
        public override double atomicWeight { get; } = 26.00052d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium26() }, { 1.0d, new BetaParticle(-1, 3671000.0) }, { 0.8420000000000001d, new GammaParticle(84000.0, 0.01476) }, { 0.034d, new GammaParticle(153000.0, 0.0081) }, { 0.044000000000000004d, new GammaParticle(232000.0, 0.00534) }, { 0.004d, new GammaParticle(404000.0, 0.00307) }, { 0.012d, new GammaParticle(1212000.0, 0.00102) }, { 0.054000000000000006d, new GammaParticle(1279000.0, 0.00097) }, { 0.006d, new GammaParticle(2219000.0, 0.00056) }, { 0.006999999999999999d, new GammaParticle(2486000.0, 0.0005) } } },
            { 0.0013d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium26() }, { 1.0d, new BetaParticle(-1, 3671000.0) }, { 0.8420000000000001d, new GammaParticle(84000.0, 0.01476) }, { 0.034d, new GammaParticle(153000.0, 0.0081) }, { 0.044000000000000004d, new GammaParticle(232000.0, 0.00534) }, { 0.004d, new GammaParticle(404000.0, 0.00307) }, { 0.012d, new GammaParticle(1212000.0, 0.00102) }, { 0.054000000000000006d, new GammaParticle(1279000.0, 0.00097) }, { 0.006d, new GammaParticle(2219000.0, 0.00056) }, { 0.006999999999999999d, new GammaParticle(2486000.0, 0.0005) } } },

        };
    }
}
    