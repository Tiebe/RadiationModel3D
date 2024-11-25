using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron65n : RadioactiveSubstance
    {
        public override string name { get; } = "Iron65n";
        public override double halfLife { get; } = 1.12d;
        public override double atomicWeight { get; } = 64.94544d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt65() }, { 1.0d, new BetaParticle(-1, 4182600.0) }, { 0.01508d, new GammaParticle(413000.0, 0.003) }, { 0.0812d, new GammaParticle(836600.0, 0.00148) }, { 0.10439999999999999d, new GammaParticle(999700.0, 0.00124) }, { 0.1276d, new GammaParticle(1412500.0, 0.00088) }, { 0.0464d, new GammaParticle(1441100.0, 0.00086) }, { 0.2726d, new GammaParticle(1479500.0, 0.00084) }, { 0.0406d, new GammaParticle(1625500.0, 0.00076) }, { 0.1334d, new GammaParticle(1641900.0, 0.00076) }, { 0.17980000000000002d, new GammaParticle(2443300.0, 0.00051) }, { 0.17980000000000002d, new GammaParticle(2557500.0, 0.00048) }, { 0.0812d, new GammaParticle(2896000.0, 0.00043) } } },

        };
    }
}
    