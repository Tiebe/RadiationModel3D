using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton70 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton70";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 69.95588d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium70() }, { 1.0d, new BetaParticle(1, 10414950.0) }, { 1.996d, new GammaParticle(511000.0, 0.00243) }, { 1.7e-05d, new GammaParticle(1535.0, 0.80771) }, { 0.00012d, new GammaParticle(11879.0, 0.10437) }, { 0.00024d, new GammaParticle(11925.0, 0.10397) }, { 6e-05d, new GammaParticle(13345.0, 0.09291) }, { 6e-05d, new GammaParticle(13377.0, 0.09268) }, { 4e-06d, new GammaParticle(13469.0, 0.09205) } } },
            { 0.013000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium69() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    