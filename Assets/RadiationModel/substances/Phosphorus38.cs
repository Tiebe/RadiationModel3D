using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus38 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus38";
        public override double halfLife { get; } = 0.64d;
        public override double atomicWeight { get; } = 37.9843d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur38() }, { 1.0d, new BetaParticle(-1, 6120500.0) }, { 0.78d, new GammaParticle(1292300.0, 0.00096) }, { 0.1794d, new GammaParticle(2224300.0, 0.00056) }, { 0.1014d, new GammaParticle(3516000.0, 0.00035) }, { 0.0858d, new GammaParticle(3698000.0, 0.00034) }, { 0.078d, new GammaParticle(4713300.0, 0.00026) }, { 3.3254011674e-08d, new GammaParticle(185.0, 6.70185) }, { 4.822747007578871e-07d, new GammaParticle(2306.0, 0.53766) }, { 9.544324178861808e-07d, new GammaParticle(2308.0, 0.53719) }, { 8.90758413559322e-08d, new GammaParticle(2466.0, 0.50277) }, { 8.90758413559322e-08d, new GammaParticle(2466.0, 0.50277) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur38() }, { 1.0d, new BetaParticle(-1, 6120500.0) }, { 0.78d, new GammaParticle(1292300.0, 0.00096) }, { 0.1794d, new GammaParticle(2224300.0, 0.00056) }, { 0.1014d, new GammaParticle(3516000.0, 0.00035) }, { 0.0858d, new GammaParticle(3698000.0, 0.00034) }, { 0.078d, new GammaParticle(4713300.0, 0.00026) }, { 3.3254011674e-08d, new GammaParticle(185.0, 6.70185) }, { 4.822747007578871e-07d, new GammaParticle(2306.0, 0.53766) }, { 9.544324178861808e-07d, new GammaParticle(2308.0, 0.53719) }, { 8.90758413559322e-08d, new GammaParticle(2466.0, 0.50277) }, { 8.90758413559322e-08d, new GammaParticle(2466.0, 0.50277) } } },

        };
    }
}
    