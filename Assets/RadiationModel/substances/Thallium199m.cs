using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium199m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium199m";
        public override double halfLife { get; } = 0.0284d;
        public override double atomicWeight { get; } = 198.97068d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium199() }, { 0.04575d, new GammaParticle(353000.0, 0.00351) }, { 0.87d, new GammaParticle(367000.0, 0.00338) }, { 0.7725d, new GammaParticle(382800.0, 0.00324) }, { 0.0195d, new GammaParticle(720000.0, 0.00172) }, { 0.08213668555824d, new GammaParticle(12148.0, 0.10206) }, { 0.043414490605666656d, new GammaParticle(70832.0, 0.0175) }, { 0.07328577077256355d, new GammaParticle(72874.0, 0.01701) }, { 0.024923648729197976d, new GammaParticle(82629.0, 0.015) }, { 0.03232597240176977d, new GammaParticle(83631.0, 0.01483) }, { 0.007402323672571799d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    