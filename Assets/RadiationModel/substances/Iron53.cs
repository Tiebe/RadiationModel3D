using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron53 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron53";
        public override double halfLife { get; } = 510.6d;
        public override double atomicWeight { get; } = 52.94531d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium53() }, { 1.0d, new BetaParticle(1, 2170060.0) }, { 0.42d, new GammaParticle(377900.0, 0.00328) }, { 0.00084d, new GammaParticle(1288000.0, 0.00096) }, { 8.4e-05d, new GammaParticle(1397600.0, 0.00089) }, { 0.00504d, new GammaParticle(1619900.0, 0.00077) }, { 0.00378d, new GammaParticle(2273500.0, 0.00055) }, { 0.000126d, new GammaParticle(2307700.0, 0.00054) }, { 0.000798d, new GammaParticle(2685600.0, 0.00046) }, { 0.001386d, new GammaParticle(2748800.0, 0.00045) }, { 0.000504d, new GammaParticle(2946600.0, 0.00042) }, { 0.000378d, new GammaParticle(3248800.0, 0.00038) }, { 1.937114d, new GammaParticle(511000.0, 0.00243) }, { 0.00019233327935852d, new GammaParticle(660.0, 1.87855) }, { 0.0024666654979861326d, new GammaParticle(5888.0, 0.21057) }, { 0.004837547554395239d, new GammaParticle(5899.0, 0.21018) }, { 0.0009926425538186285d, new GammaParticle(6512.0, 0.19039) }, { 0.0009926425538186285d, new GammaParticle(6512.0, 0.19039) } } },

        };
    }
}
    