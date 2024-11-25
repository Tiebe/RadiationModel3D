using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium128m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium128m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 127.95465d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium128() }, { 0.28d, new GammaParticle(75100.0, 0.01651) }, { 0.74d, new GammaParticle(260100.0, 0.00477) }, { 0.88d, new GammaParticle(504400.0, 0.00246) }, { 1.0d, new GammaParticle(1311400.0, 0.00095) }, { 0.05594547704d, new GammaParticle(3053.0, 0.40611) }, { 0.18963719519504743d, new GammaParticle(21020.0, 0.05898) }, { 0.3582792276498157d, new GammaParticle(21177.0, 0.05855) }, { 0.09829714286763828d, new GammaParticle(23904.0, 0.05187) }, { 0.11500765715513678d, new GammaParticle(24070.0, 0.05151) }, { 0.016710514287498507d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    