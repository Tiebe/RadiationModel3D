using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten190n : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten190n";
        public override double halfLife { get; } = 0.00017d;
        public override double atomicWeight { get; } = 189.96508d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten190() }, { 0.0204d, new GammaParticle(97000.0, 0.01278) }, { 0.038d, new GammaParticle(102000.0, 0.01216) }, { 0.784d, new GammaParticle(206800.0, 0.006) }, { 0.9515d, new GammaParticle(358300.0, 0.00346) }, { 0.9777d, new GammaParticle(484300.0, 0.00256) }, { 0.204d, new GammaParticle(593600.0, 0.00209) }, { 0.785d, new GammaParticle(694000.0, 0.00179) }, { 0.330340329633175d, new GammaParticle(9740.0, 0.12729) }, { 0.27518122615865254d, new GammaParticle(57983.0, 0.02138) }, { 0.47799413958424963d, new GammaParticle(59320.0, 0.0209) }, { 0.1584387739553358d, new GammaParticle(67335.0, 0.01841) }, { 0.20185099801909778d, new GammaParticle(68117.0, 0.0182) }, { 0.043412224063762d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    