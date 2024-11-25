using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten180m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten180m";
        public override double halfLife { get; } = 0.00547d;
        public override double atomicWeight { get; } = 179.94835d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten180() }, { 0.228d, new GammaParticle(103568.0, 0.01197) }, { 1.14d, new GammaParticle(233990.0, 0.0053) }, { 1.1514d, new GammaParticle(350898.0, 0.00353) }, { 1.14d, new GammaParticle(390581.0, 0.00317) }, { 1.3337999999999999d, new GammaParticle(450018.0, 0.00276) }, { 0.24309618637500002d, new GammaParticle(9740.0, 0.12729) }, { 0.10929762642187768d, new GammaParticle(57983.0, 0.02138) }, { 0.1898517047453147d, new GammaParticle(59320.0, 0.0209) }, { 0.06292937264741567d, new GammaParticle(67335.0, 0.01841) }, { 0.08017202075280756d, new GammaParticle(68117.0, 0.0182) }, { 0.017242648105391896d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    