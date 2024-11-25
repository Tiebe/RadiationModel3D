using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine34 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine34";
        public override double halfLife { get; } = 1.5266d;
        public override double atomicWeight { get; } = 33.97376d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus34() }, { 1.0d, new BetaParticle(1, 54305.0) }, { 1.998416d, new GammaParticle(511000.0, 0.00243) }, { 1.266076611e-06d, new GammaParticle(185.0, 6.70185) }, { 1.819832607273509e-05d, new GammaParticle(2306.0, 0.53766) }, { 3.601489426624795e-05d, new GammaParticle(2308.0, 0.53719) }, { 3.3612196610169485e-06d, new GammaParticle(2466.0, 0.50277) }, { 3.3612196610169485e-06d, new GammaParticle(2466.0, 0.50277) } } },

        };
    }
}
    