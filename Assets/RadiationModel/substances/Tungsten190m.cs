using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten190m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten190m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 189.96497d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten190() }, { 0.038d, new GammaParticle(102000.0, 0.01216) }, { 0.784d, new GammaParticle(206800.0, 0.006) }, { 0.9515d, new GammaParticle(358300.0, 0.00346) }, { 0.9777d, new GammaParticle(484300.0, 0.00256) }, { 0.20600000000000002d, new GammaParticle(593600.0, 0.00209) }, { 0.785d, new GammaParticle(694000.0, 0.00179) }, { 0.106620778849175d, new GammaParticle(9740.0, 0.12729) }, { 0.08845199674968525d, new GammaParticle(57983.0, 0.02138) }, { 0.15364251650110342d, new GammaParticle(59320.0, 0.0209) }, { 0.05092726024427893d, new GammaParticle(67335.0, 0.01841) }, { 0.06488132955121136d, new GammaParticle(68117.0, 0.0182) }, { 0.013954069306932427d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    