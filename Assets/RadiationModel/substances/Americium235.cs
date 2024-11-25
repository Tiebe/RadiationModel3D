using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium235";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 235.0479d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium235() }, { 0.007968d, new GammaParticle(511000.0, 0.00243) }, { 0.06d, new GammaParticle(17604.0, 0.07043) }, { 0.03d, new GammaParticle(99533.0, 0.01246) }, { 0.06d, new GammaParticle(103741.0, 0.01195) }, { 0.02d, new GammaParticle(117130.0, 0.01059) }, { 0.03d, new GammaParticle(118619.0, 0.01045) }, { 0.006999999999999999d, new GammaParticle(120544.0, 0.01029) } } },
            { 0.004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium231() }, { 1.0d, new AlphaParticle(7597002.09) } } },

        };
    }
}
    