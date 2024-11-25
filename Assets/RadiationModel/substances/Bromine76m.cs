using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine76m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine76m";
        public override double halfLife { get; } = 1.31d;
        public override double atomicWeight { get; } = 75.92465d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine76() }, { 0.484d, new GammaParticle(45480.0, 0.02726) }, { 0.091d, new GammaParticle(57110.0, 0.02171) }, { 0.000997d, new GammaParticle(102600.0, 0.01208) }, { 0.031d, new GammaParticle(1535.0, 0.80771) }, { 0.223d, new GammaParticle(11879.0, 0.10437) }, { 0.43d, new GammaParticle(11925.0, 0.10397) }, { 0.102d, new GammaParticle(13345.0, 0.09291) }, { 0.1099d, new GammaParticle(13377.0, 0.09268) }, { 0.0079d, new GammaParticle(13469.0, 0.09205) } } },
            { 0.003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic76() }, { 1.0d, new BetaParticle(1, 1052700.0) }, { 0.003d, new GammaParticle(559000.0, 0.00222) }, { 0.003d, new GammaParticle(772000.0, 0.00161) }, { 0.0104d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    