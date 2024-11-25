using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead212 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead212";
        public override double halfLife { get; } = 38239.2d;
        public override double atomicWeight { get; } = 211.9919d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth212() }, { 1.0d, new BetaParticle(-1, 284500.0) }, { 0.0059644799999999994d, new GammaParticle(115183.0, 0.01076) }, { 0.0005232d, new GammaParticle(176680.0, 0.00702) }, { 0.436d, new GammaParticle(238632.0, 0.0052) }, { 0.0330052d, new GammaParticle(300087.0, 0.00413) }, { 0.0001308d, new GammaParticle(415200.0, 0.00299) }, { 0.13675041642107744d, new GammaParticle(12904.0, 0.09608) }, { 0.10027299973093201d, new GammaParticle(74815.0, 0.01657) }, { 0.16776476448206798d, new GammaParticle(77108.0, 0.01608) }, { 0.05746598313908116d, new GammaParticle(87388.0, 0.01419) }, { 0.07505057397964d, new GammaParticle(88458.0, 0.01402) }, { 0.017584590840558835d, new GammaParticle(89784.0, 0.01381) } } },

        };
    }
}
    