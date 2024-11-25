using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium30 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium30";
        public override double halfLife { get; } = 0.319d;
        public override double atomicWeight { get; } = 29.99047d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum30() }, { 1.0d, new BetaParticle(-1, 3491350.0) }, { 0.77d, new GammaParticle(243800.0, 0.00509) }, { 0.7392d, new GammaParticle(443800.0, 0.00279) }, { 0.00308d, new GammaParticle(611100.0, 0.00203) }, { 0.03234d, new GammaParticle(687700.0, 0.0018) }, { 0.00462d, new GammaParticle(1557700.0, 0.0008) }, { 0.03696d, new GammaParticle(1724600.0, 0.00072) }, { 0.02464d, new GammaParticle(2169100.0, 0.00057) }, { 0.00231d, new GammaParticle(2412600.0, 0.00051) }, { 0.00308d, new GammaParticle(2476400.0, 0.0005) }, { 0.005390000000000001d, new GammaParticle(3118800.0, 0.0004) }, { 2.065106274e-07d, new GammaParticle(91.0, 13.62464) }, { 3.136622499844124e-06d, new GammaParticle(1487.0, 0.83379) }, { 6.232113053534916e-06d, new GammaParticle(1487.0, 0.83379) }, { 1.967434466209599e-07d, new GammaParticle(1558.0, 0.79579) }, { 1.967434466209599e-07d, new GammaParticle(1558.0, 0.79579) } } },

        };
    }
}
    