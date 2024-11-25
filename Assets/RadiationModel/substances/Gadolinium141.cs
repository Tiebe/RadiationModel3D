using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium141";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 140.93213d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium141() }, { 1.0d, new BetaParticle(1, 6355000.0) }, { 0.09300000000000001d, new GammaParticle(120600.0, 0.01028) }, { 0.028999999999999998d, new GammaParticle(173100.0, 0.00716) }, { 0.034d, new GammaParticle(189700.0, 0.00654) }, { 0.544d, new GammaParticle(215800.0, 0.00575) }, { 0.02d, new GammaParticle(293300.0, 0.00423) }, { 0.172d, new GammaParticle(336200.0, 0.00369) }, { 0.172d, new GammaParticle(525900.0, 0.00236) }, { 0.01d, new GammaParticle(1072600.0, 0.00116) }, { 0.069d, new GammaParticle(1192800.0, 0.00104) }, { 1.77d, new GammaParticle(511000.0, 0.00243) }, { 0.0512665379016d, new GammaParticle(6603.0, 0.18777) }, { 0.07525199304812406d, new GammaParticle(40901.0, 0.03031) }, { 0.13578490264908707d, new GammaParticle(41541.0, 0.02985) }, { 0.042777749127813076d, new GammaParticle(47146.0, 0.0263) }, { 0.053814408402788845d, new GammaParticle(47645.0, 0.02602) }, { 0.011036659274975774d, new GammaParticle(48248.0, 0.0257) } } },
            { 0.0003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium140() }, { 1.0d, new BetaParticle(1, 471863051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    