using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium151n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium151n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 150.94835d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium151() }, { 0.5568d, new GammaParticle(140400.0, 0.00883) }, { 0.12179999999999999d, new GammaParticle(215700.0, 0.00575) }, { 0.8526d, new GammaParticle(338800.0, 0.00366) }, { 0.1305d, new GammaParticle(393900.0, 0.00315) }, { 0.1305d, new GammaParticle(415800.0, 0.00298) }, { 0.8961d, new GammaParticle(698800.0, 0.00177) }, { 0.87d, new GammaParticle(1477700.0, 0.00084) }, { 0.1305d, new GammaParticle(1489800.0, 0.00083) }, { 0.089074625664d, new GammaParticle(8215.0, 0.15092) }, { 0.06688538401927413d, new GammaParticle(49773.0, 0.02491) }, { 0.11808860172894443d, new GammaParticle(50742.0, 0.02443) }, { 0.038609649406175776d, new GammaParticle(57612.0, 0.02152) }, { 0.04864815825178148d, new GammaParticle(58257.0, 0.02128) }, { 0.010038508845605703d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    