using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine79m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine79m";
        public override double halfLife { get; } = 4.85d;
        public override double atomicWeight { get; } = 78.91856d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine79() }, { 0.763d, new GammaParticle(207500.0, 0.00598) }, { 0.0052098312d, new GammaParticle(1535.0, 0.80771) }, { 0.037056965101916126d, new GammaParticle(11879.0, 0.10437) }, { 0.07152473480392998d, new GammaParticle(11925.0, 0.10397) }, { 0.016964630610985798d, new GammaParticle(13345.0, 0.09291) }, { 0.0182743000941539d, new GammaParticle(13377.0, 0.09268) }, { 0.0013096694831681035d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    