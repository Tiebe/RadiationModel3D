using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine88m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine88m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 87.92437d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine88() }, { 0.625d, new GammaParticle(110900.0, 0.01118) }, { 0.9618000000000001d, new GammaParticle(159100.0, 0.00779) }, { 0.009038300919999999d, new GammaParticle(1535.0, 0.80771) }, { 0.06525327963738399d, new GammaParticle(11879.0, 0.10437) }, { 0.1259472681671183d, new GammaParticle(11925.0, 0.10397) }, { 0.02987286687290915d, new GammaParticle(13345.0, 0.09291) }, { 0.032179052195497736d, new GammaParticle(13377.0, 0.09268) }, { 0.0023061853225885866d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    