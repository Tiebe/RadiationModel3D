using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium156m";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 155.93128d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium156() }, { 0.045570000000000006d, new GammaParticle(150300.0, 0.00825) }, { 0.11164613544d, new GammaParticle(6109.0, 0.20295) }, { 0.1669608626620783d, new GammaParticle(38171.0, 0.03248) }, { 0.30312429677211017d, new GammaParticle(38724.0, 0.03202) }, { 0.0939796344994523d, new GammaParticle(43934.0, 0.02822) }, { 0.11813240056581155d, new GammaParticle(44387.0, 0.02793) }, { 0.02415276606635924d, new GammaParticle(44938.0, 0.02759) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium156() }, { 1.0d, new BetaParticle(-1, 2672250.0) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium152() }, { 1.0d, new AlphaParticle(-1661497.9100000001) } } },

        };
    }
}
    